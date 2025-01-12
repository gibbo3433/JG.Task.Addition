using JG.Task.Addition.Data;
using JG.Task.Addition.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace JG.Task.Addition.Services

{
    public class AdditionActivityService
    {
        private readonly ApplicationDbContext _context; // Dependancy Injection

        public AdditionActivityService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<decimal> AddingTwoNumbersToDatabase(decimal FirstNumber, decimal SecondNumber)
        {
            //if (FirstNumber == null && SecondNumber == null) { return BadRequest("Both numbers are required"); }

                      
                decimal result = FirstNumber + SecondNumber;

                var entity = new Calculations
                {
                    FirstNumber = FirstNumber,
                    SecondNumber = SecondNumber,
                    Result = result
                };

                _context.Calculations.Add(entity);
                await _context.SaveChangesAsync();

                return result;                
            
            
        }
        
    }

    }
