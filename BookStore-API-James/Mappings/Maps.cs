using AutoMapper;
using BookStore_API_James.Data;
using BookStore_API_James.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API_James.Mappings
{
	public class Maps : Profile
	{
		public Maps(){
			CreateMap<Author, AuthorDTO>().ReverseMap();
			CreateMap<Book, BookDTO>().ReverseMap();
		}
		
	}
}
