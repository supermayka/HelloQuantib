﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HelloQuantib
{
    public static class JsonFileUtils
    {

        private static readonly JsonSerializerOptions _options =
            new JsonSerializerOptions() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };

        public static void SimpleWrite(object obj, string fileName)
        {
            var jsonString = JsonSerializer.Serialize(obj, _options);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
