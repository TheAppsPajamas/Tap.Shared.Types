﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Enums
{
    public class MediaFieldType : FieldType
    {
        private int _width;
        public virtual int Width { get { return _width; } }

        private int _height;
        public virtual int Height { get { return _height; } }

        public MediaFieldType(int value
            , string displayName
            , ProjectType projectType
            , FieldHolderType fieldHolderType
            , int order
            , bool isForClient
            , Dictionary<string, string> metadata
            , int width
            , int height = 0) : base(value, displayName, projectType, fieldHolderType, order, isForClient, metadata)
        {
            _width = width;
            if (height == 0)
            {
                _height = width;
            }
            else
            {
                _height = height;
            }
        }

    }
}
