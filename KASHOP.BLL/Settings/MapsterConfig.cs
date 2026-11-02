using KASHOP.DAL.DTO.Responses;
using KASHOP.DAL.Models;
using Mapster;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace KASHOP.BLL.Settings
{
    public class MapsterConfig
    {
        public static void RegisterMappings()
        {
            TypeAdapterConfig<Category, CategoryResponse>.NewConfig()
                .Map(
                    dest => dest.Name, src => src.Translations
                    .Where(t => t.Language == CultureInfo.CurrentUICulture.TwoLetterISOLanguageName)
                    .Select(t => t.Name).FirstOrDefault()
                   );
        }
    }
}
