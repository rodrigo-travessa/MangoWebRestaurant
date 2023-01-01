﻿namespace Mango.Services.ProductAPI.Models.Dto
{
    public class ResponseDto
    {
        public bool IsSucess { get; set; } = true;
        public object Result { get; set; }
        public string DisplayMessage { get; set; } = "";
        public List<String> ErrorMessages { get; set; }
    }
}
