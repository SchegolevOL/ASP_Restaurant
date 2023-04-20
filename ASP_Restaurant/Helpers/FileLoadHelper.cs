namespace ASP_Restaurant.Helpers
{
    public static class FileLoadHelper
    {
        static public async Task<string> UploadAsync(IFormFile file)
        {
            if (file != null)
            {
                var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
                using var fs = new FileStream(@$"wwwroot/img/{fileName}", FileMode.Create);
                await file.CopyToAsync(fs);
                return @$"/img/{fileName}";
            }

            throw new Exception("File was not uploaded!");
        }
    }
}
