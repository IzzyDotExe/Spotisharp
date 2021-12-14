﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotisharp.Client.Resolvers
{
    public static class FilesystemResolver
    {
        public static string ReplaceForbiddenChars(string input)
        {
            char[] forbiddenChars = { '<', '>', ':',
                '"', '/', '\\', 
                '|', '?', '*' 
            };

            return string.Create(input.Length, input, (chars, buffer) =>
            {
                for(int i = 0; i < buffer.Length; i++)
                {
                    for(int j = 0; j < forbiddenChars.Length; j++)
                    {
                        if(buffer[i] == forbiddenChars[j])
                        {
                            chars[i] = ' ';
                            break;
                        }
                        else
                        {
                            chars[i] = buffer[i];
                        }
                    }
                }
            });
        }
    }
}
