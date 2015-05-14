﻿/*
 * FILE         |   Table.cs
 * PROJECT      |   ASQL Assignment #3
 * DATE         |   27-03-2015
 * AUTHOR       |   Greg Kozyrev & Ben Lorantfy
 * DESCRIPTION  |   Purpose of this file is to create container for database data
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etl
{
    public class MyTable
    {
        public String Name { get; set; }
        private List<MyColumn> columns;
        private List<MyRow> rows;

        public MyTable(String newName)
        {
            Name = newName;
            columns = new List<MyColumn>();
            rows = new List<MyRow>();
        }

        public void AddColumn(MyColumn newColumn)
        {
            columns.Add(newColumn);
        }

        public void AddRow(MyRow newRow)
        {
            rows.Add(newRow);
        }

        public List<MyColumn> GetColumns()
        {
            return columns;
        }

        public List<MyRow> GetRows()
        {
            return rows;
        }
    }

    public class MyColumn
    {
        public String Name { get; set; }
        public String Type { get; set; }
        public String Size { get; set; }

        public MyColumn(String newName, String newType, String newSize)
        {
            Name = newName;
            Type = newType;
            Size = newSize;
        }
        public override bool Equals(System.Object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Point return false.
            MyColumn p = obj as MyColumn;
            if ((System.Object)p == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (Name.Equals(p.Name)) && (Type.Equals(p.Type)) && (Size.Equals(p.Size));
        }
    }

    public class MyRow
    {
        private Dictionary<String, String> rowFields = new Dictionary<String, String>(); 
        public void AddField(String name, String content)
        {
            rowFields.Add(name,content);
        }
        public String GetField(String name)
        {
            return rowFields[name];
        }
    }
}
