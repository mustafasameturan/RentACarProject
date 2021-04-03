using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        private static string _currentFileDirectory = Environment.CurrentDirectory + "\\wwwroot";
        private static string _folderName = "\\images\\";

        public static IResult Add(IFormFile file)
        {
            var fileExist = CheckFileExists(file);
            if (fileExist.Message != null)
            {
                return new ErrorResult(fileExist.Message);
            }

            var type = Path.GetExtension(file.FileName);
            var typeValid = CheckFileTypeValid(type);
            var randomName = Guid.NewGuid().ToString();

            if (typeValid.Message != null)
            {
                return new ErrorResult(typeValid.Message);
            }

            CheckFileDirectoryExist(_currentFileDirectory + _folderName);
            CreateImageFile(_currentFileDirectory + _folderName + randomName + type, file);
            return new SuccessResult((_folderName + randomName + type).Replace("\\","/"));
        }

        public static IResult Update(string imagePath, IFormFile file)
        {
            var fileExist = CheckFileExists(file);
            if (fileExist.Message != null)
            {
                return new ErrorResult(fileExist.Message);
            }

            var type = Path.GetExtension(file.FileName);
            var typeValid = CheckFileTypeValid(type);
            var randomName = Guid.NewGuid().ToString();

            if (typeValid.Message != null)
            {
                return new ErrorResult(typeValid.Message);
            }

            DeleteOldImageFile((_currentFileDirectory + imagePath).Replace("/", "\\"));
            CheckFileDirectoryExist(_currentFileDirectory + _folderName);
            CreateImageFile(_currentFileDirectory + _folderName + randomName + type, file);

            return new SuccessResult((_folderName + randomName + type).Replace("\\","/"));

        }

        public static IResult Delete(string path)
        {
            DeleteOldImageFile((_currentFileDirectory + path).Replace("/", "\\"));
            return new SuccessResult();
        }


        //Verification Methods

        private static IResult CheckFileTypeValid(string type)
        {
            if (type != ".jpeg" && type !=".png" && type != ".jpg")
            {
                return new ErrorResult("File Type Is Wrong!");
            }

            return new SuccessResult();
        }

        private static IResult CheckFileExists(IFormFile file)
        {
            if(file != null && file.Length > 0)
            {
                return new SuccessResult();
            }
            return new ErrorResult("File Not Found!");
        }

        private static void DeleteOldImageFile(string directory)
        {
            if (File.Exists(directory.Replace("/","\\")))
            {
                File.Delete(directory.Replace("/", "\\"));
            }
        }

        private static void CheckFileDirectoryExist(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        private static void CreateImageFile(string directory, IFormFile file)
        {
            using (FileStream fs = File.Create(directory))
            {
                file.CopyTo(fs);
                fs.Flush();
            }
        }
    }
}
