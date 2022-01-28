using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.DTO;

namespace Repository_Pattern
{
    public class BooksRepository
    {
        private Database Db { get; }
        public BooksRepository(Database db)
        {
            Db = db;
        }
        public List<BookDTO> GetBooks(PaginationDTO pagination)
        {
            return Db.Books.Include(b => b.Rates)
            .Include(b => b.Authors)
            .Skip(pagination.Page * pagination.Count)
            .Take(pagination.Count)
            .ToList().Select(b => new BookDTO
            {
                Id = b.Id,
                ReleaseDate = b.ReleaseDate,
                AvarageRates = (b.Rates.Count() > 0 ? b.Rates.Average(r => r.Value) : 0),
                RatesCount = (b.Rates.Count() > 0 ? b.Rates.Count() : 0),
                Title = b.Title,
                Description=b.Description,
                Authors = b.Authors.Select(a => new AuthorDTO
                {
                    FirstName = a.FirstName,
                    Id = a.Id,
                    SecondName = a.SecondName,
                    CV=a.CV
                }).ToList()
            }).ToList();
        }

        public BookDTO GetBookbyId(int Idx)
        {
            return Db.Books.Include(b => b.Rates)
            .Include(b => b.Authors)
            .ToList().Select(b => new BookDTO
            {
                Id = b.Id,
                ReleaseDate = b.ReleaseDate,
                AvarageRates = (b.Rates.Count() > 0 ? b.Rates.Average(r => r.Value):0),
                RatesCount = (b.Rates.Count()>0 ? b.Rates.Count() : 0),
                Title = b.Title,
                Description=b.Description,
                Authors = b.Authors.Select(a => new AuthorDTO
                {
                    FirstName = a.FirstName,
                    Id = a.Id,
                    SecondName = a.SecondName,
                    CV=a.CV
                }).ToList()
            }).Where(b => b.Id == Idx).FirstOrDefault();

        }

        public BookDTO PostBook(BookRequestDTO brq)
        {
            Book book = new Book
            {
                Title = brq.Title,
                ReleaseDate = brq.ReleaseDate,
                Description=brq.Description

            };
            if (brq.AuthorsId == null)
            {
                book.Authors = new List<Author>();
            }
            else
            {
                book.Authors = Db.Authors.Where(a => brq.AuthorsId.Contains(a.Id)).ToList();
            }
            Db.Books.Add(book);
            Db.SaveChanges();

            return new BookDTO
            {
                Id = book.Id,
                Authors = book.Authors.Select(a => new AuthorDTO
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    SecondName = a.SecondName,
                    CV=a.CV
                }).ToList(),
                AvarageRates = 0,
                RatesCount = 0,
                Description=book.Description,
                ReleaseDate = book.ReleaseDate,
                Title = book.Title
            };

        }

        public BookDTO PutBook(int id, BookRequestDTO brq)
        {
            Book book = Db.Books.Include(x => x.Authors).Where(x => x.Id == id).Single();
            {
                book.Title = brq.Title;
                book.ReleaseDate = brq.ReleaseDate;
                book.Description = brq.Description;
            };
            if (brq.AuthorsId == null)
            {
                book.Authors = new List<Author>();
            }
            else
            {
                book.Authors = Db.Authors.Where(a => brq.AuthorsId.Contains(a.Id)).ToList();
            }
            Db.Books.Update(book);
            Db.SaveChanges();

            return new BookDTO
            {
                Id = book.Id,
                Authors = book.Authors.Select(a => new AuthorDTO
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    SecondName = a.SecondName,
                    CV = a.CV
                }).ToList(),
                AvarageRates = (book.Rates.Count() > 0 ? book.Rates.Average(r => r.Value) : 0),
                RatesCount = (book.Rates.Count() > 0 ? book.Rates.Count() : 0),
                Description = book.Description,
                ReleaseDate = book.ReleaseDate,
                Title = book.Title
            };

        }

        public bool DeleteDTO(int id)
        {
            Book del = Db.Books.Where(x => x.Id == id).FirstOrDefault();

            Db.Books.Remove(del);
            Db.SaveChanges();

            return true;
        }

        public void AddBookRate(int id, int rate)
        {
            Book des = Db.Books.Where(x => x.Id == id).FirstOrDefault();

            Db.BookRates.Add(new BookRate
            {
                RateType = RateType.BookRate,
                Book = des,
                FkBook = des.Id,
                Date = DateTime.Now,
                Value = (short)rate
            });

            Db.SaveChanges();

        }


    }
}
