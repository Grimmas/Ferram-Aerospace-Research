using System;
using System.Collections.Generic;
using UnityEngine;

namespace FerramAerospaceResearch
{
    // interface extracted from ConfigNode for use in projects that cannot reference KSP assemblies
    public interface IConfigNode
    {
        string Name { get; set; }
        string ID { get; set; }
        string Comment { get; set; }

        bool HasData { get; }
        int CountValues { get; }
        int CountNodes { get; }
        void CopyTo(IConfigNode node);
        void CopyTo(IConfigNode node, bool overwrite);
        void CopyTo(IConfigNode node, string newName);
        IConfigNode CreateCopy();
        bool Save(string fileFullName);
        bool Save(string fileFullName, string header);
        void ClearData();
        void AddData(IConfigNode node);
        bool HasValue(string name);
        bool HasValue();
        void AddValue(string name, object value, string vcomment);
        void AddValue(string name, string value, string vcomment);
        void AddValue(string name, object value);
        void AddValue(string name, string value);
        void AddValue(string name, bool value, string vcomment);
        void AddValue(string name, bool value);
        void AddValue(string name, byte value, string vcomment);
        void AddValue(string name, byte value);
        void AddValue(string name, sbyte value, string vcomment);
        void AddValue(string name, sbyte value);
        void AddValue(string name, char value, string vcomment);
        void AddValue(string name, char value);
        void AddValue(string name, decimal value, string vcomment);
        void AddValue(string name, decimal value);
        void AddValue(string name, double value, string vcomment);
        void AddValue(string name, double value);
        void AddValue(string name, float value, string vcomment);
        void AddValue(string name, float value);
        void AddValue(string name, int value, string vcomment);
        void AddValue(string name, int value);
        void AddValue(string name, uint value, string vcomment);
        void AddValue(string name, uint value);
        void AddValue(string name, long value, string vcomment);
        void AddValue(string name, long value);
        void AddValue(string name, ulong value, string vcomment);
        void AddValue(string name, ulong value);
        void AddValue(string name, short value, string vcomment);
        void AddValue(string name, short value);
        void AddValue(string name, ushort value, string vcomment);
        void AddValue(string name, ushort value);
        void AddValue(string name, Vector2 value, string vcomment);
        void AddValue(string name, Vector2 value);
        void AddValue(string name, Vector3 value, string vcomment);
        void AddValue(string name, Vector3 value);
        void AddValue(string name, Vector3d value, string vcomment);
        void AddValue(string name, Vector3d value);
        void AddValue(string name, Vector4 value, string vcomment);
        void AddValue(string name, Vector4 value);
        void AddValue(string name, Quaternion value, string vcomment);
        void AddValue(string name, Quaternion value);
        void AddValue(string name, QuaternionD value, string vcomment);
        void AddValue(string name, QuaternionD value);
        void AddValue(string name, Matrix4x4 value, string vcomment);
        void AddValue(string name, Matrix4x4 value);
        void AddValue(string name, Color value, string vcomment);
        void AddValue(string name, Color value);
        void AddValue(string name, Color32 value, string vcomment);
        void AddValue(string name, Color32 value);
        string GetValue(string name);
        string GetValue(string name, int index);
        string[] GetValues();
        string[] GetValues(string name);
        List<string> GetValuesList(string name);
        string[] GetValuesStartsWith(string name);
        bool SetValue(string name, string newValue, bool createIfNotFound = false);
        bool SetValue(string name, string newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, string newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            string newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, bool newValue, bool createIfNotFound = false);
        bool SetValue(string name, bool newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, bool newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            bool newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, byte newValue, bool createIfNotFound = false);
        bool SetValue(string name, byte newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, byte newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            byte newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, sbyte newValue, bool createIfNotFound = false);
        bool SetValue(string name, sbyte newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, sbyte newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            sbyte newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, char newValue, bool createIfNotFound = false);
        bool SetValue(string name, char newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, char newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            char newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, decimal newValue, bool createIfNotFound = false);
        bool SetValue(string name, decimal newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, decimal newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            decimal newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, double newValue, bool createIfNotFound = false);
        bool SetValue(string name, double newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, double newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            double newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, float newValue, bool createIfNotFound = false);
        bool SetValue(string name, float newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, float newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            float newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, int newValue, bool createIfNotFound = false);
        bool SetValue(string name, int newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, int newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            int newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, uint newValue, bool createIfNotFound = false);
        bool SetValue(string name, uint newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, uint newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            uint newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, long newValue, bool createIfNotFound = false);
        bool SetValue(string name, long newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, long newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            long newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, ulong newValue, bool createIfNotFound = false);
        bool SetValue(string name, ulong newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, ulong newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            ulong newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, short newValue, bool createIfNotFound = false);
        bool SetValue(string name, short newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, short newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            short newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, ushort newValue, bool createIfNotFound = false);
        bool SetValue(string name, ushort newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, ushort newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            ushort newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, Vector2 newValue, bool createIfNotFound = false);
        bool SetValue(string name, Vector2 newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, Vector2 newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            Vector2 newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, Vector3 newValue, bool createIfNotFound = false);
        bool SetValue(string name, Vector3 newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, Vector3 newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            Vector3 newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, Vector3d newValue, bool createIfNotFound = false);
        bool SetValue(string name, Vector3d newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, Vector3d newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            Vector3d newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, Vector4 newValue, bool createIfNotFound = false);
        bool SetValue(string name, Vector4 newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, Vector4 newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            Vector4 newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, Quaternion newValue, bool createIfNotFound = false);
        bool SetValue(string name, Quaternion newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, Quaternion newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            Quaternion newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, QuaternionD newValue, bool createIfNotFound = false);
        bool SetValue(string name, QuaternionD newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, QuaternionD newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            QuaternionD newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, Matrix4x4 newValue, bool createIfNotFound = false);
        bool SetValue(string name, Matrix4x4 newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, Matrix4x4 newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            Matrix4x4 newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, Color newValue, bool createIfNotFound = false);
        bool SetValue(string name, Color newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, Color newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            Color newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        bool SetValue(string name, Color32 newValue, bool createIfNotFound = false);
        bool SetValue(string name, Color32 newValue, int index, bool createIfNotFound = false);
        bool SetValue(string name, Color32 newValue, string vcomment, bool createIfNotFound = false);

        bool SetValue(
            string name,
            Color32 newValue,
            string vcomment,
            int index,
            bool createIfNotFound = false);

        void RemoveValue(string name);
        void RemoveValues(params string[] names);
        void RemoveValues(string startsWith);
        void RemoveValuesStartWith(string startsWith);
        void ClearValues();
        bool HasNodeID(string id);
        bool HasNode(string name);
        bool HasNode();
        IConfigNode AddNode(string name);
        IConfigNode AddNode(string name, string vcomment);
        IConfigNode AddNode(IConfigNode node);
        IConfigNode AddNode(string name, IConfigNode node);
        IConfigNode GetNodeID(string id);
        IConfigNode GetNode(string name);
        IConfigNode GetNode(string name, string valueName, string value);
        IConfigNode GetNode(string name, int index);
        IConfigNode[] GetNodes(string name);
        IConfigNode[] GetNodes(string name, string valueName, string value);
        IConfigNode[] GetNodes();
        bool SetNode(string name, IConfigNode newNode, bool createIfNotFound = false);
        bool SetNode(string name, IConfigNode newNode, int index, bool createIfNotFound = false);
        void RemoveNode(string name);
        void RemoveNode(IConfigNode node);
        void RemoveNodesStartWith(string startsWith);
        void RemoveNodes(string name);
        void ClearNodes();
        bool TryGetNode(string name, ref IConfigNode node);
        bool TryGetValue(string name, ref string value);
        bool TryGetValue(string name, ref string[] value);
        bool TryGetValue(string name, ref float value);
        bool TryGetValue(string name, ref double value);
        bool TryGetValue(string name, ref int value);
        bool TryGetValue(string name, ref uint value);
        bool TryGetValue(string name, ref long value);
        bool TryGetValue(string name, ref ulong value);
        bool TryGetValue(string name, ref bool value);
        bool TryGetValue(string name, ref Vector3 value);
        bool TryGetValue(string name, ref Vector3d value);
        bool TryGetValue(string name, ref Vector2 value);
        bool TryGetValue(string name, ref Vector2d value);
        bool TryGetValue(string name, ref Vector4 value);
        bool TryGetValue(string name, ref Vector4d value);
        bool TryGetValue(string name, ref Quaternion value);
        bool TryGetValue(string name, ref QuaternionD value);
        bool TryGetValue(string name, ref Rect value);
        bool TryGetValue(string name, ref Color value);
        bool TryGetValue(string name, ref Color32 value);
        bool HasValues(params string[] values);
        bool TryGetValue(string name, ref Guid value);
        bool TryGetEnum<T>(string name, ref T value, T defaultValue) where T : IComparable, IFormattable, IConvertible;
        bool TryGetEnum(string name, Type enumType, ref Enum value);
    }
}