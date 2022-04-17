﻿using System.Collections.Generic;

namespace EditorApp.Lib
{
    public abstract class File
    {
        protected string path;
        protected object content;

        protected File(string path, string content)
        {
            this.path = path;
            this.content = content;
        }
    }
}