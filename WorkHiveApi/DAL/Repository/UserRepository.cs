﻿using DAL.Repository.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public  UserRepository(AppDbContext dbContext)
            {
              _dbContext = dbContext;
            }
       public  List<User> GetUsers()
        {
            try
            {
                return _dbContext.Users.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public User GetUserDetails(int userId)
        {
            try
            {
                return _dbContext.Users.Where(x=>x.UserId== userId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User GetUserDetails(string username, string password)
        {
            try
            {
                return _dbContext.Users.Where(x => x.Email == username && x.Password== password).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public User CreateUser(User user)
        {
            try
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
                return user;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
