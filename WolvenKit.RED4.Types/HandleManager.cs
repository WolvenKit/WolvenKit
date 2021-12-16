using System;
using System.Collections.Generic;
using System.Linq;

namespace WolvenKit.RED4.Types
{
    public sealed class HandleManager
    {
        private Red4File _file;

        private readonly HashSet<int> _pointers = new();
        private readonly Dictionary<int, ChunkRef> _refDict = new();

        public HandleManager(Red4File red4File)
        {
            _file = red4File;
        }

        internal void RegisterHandle(IRedBaseHandle handle)
        {
            if (_pointers.Add(handle.Pointer))
            {
                _refDict.Add(handle.Pointer, new ChunkRef(handle.Pointer));
            }

            _refDict[handle.Pointer].Handles.Add(handle);
        }

        public CHandle<T> CreateCHandle<T>(IRedClass cls) where T : IRedClass
        {
            var pointer = _file._chunks.IndexOf(cls);
            if (pointer == -1)
            {
                _file._chunks.Add(cls);
                pointer = _file._chunks.Count - 1;
            }

            var result = new CHandle<T>(_file, pointer);

            RegisterHandle(result);

            return result;
        }

        public CHandle<T> CreateCHandle<T>(int pointer) where T : IRedClass
        {
            var result = new CHandle<T>(_file, pointer);

            RegisterHandle(result);

            return result;
        }

        public CWeakHandle<T> CreateCWeakHandle<T>(IRedClass cls) where T : IRedClass
        {
            var pointer = _file._chunks.IndexOf(cls);
            if (pointer == -1)
            {
                _file._chunks.Add(cls);
                pointer = _file._chunks.Count - 1;
            }

            var result = new CWeakHandle<T>(_file, pointer);

            RegisterHandle(result);

            return result;
        }

        public CWeakHandle<T> CreateCWeakHandle<T>(int pointer) where T : IRedClass
        {
            var result = new CWeakHandle<T>(_file, pointer);

            RegisterHandle(result);

            return result;
        }

        internal IRedClass Get(int pointer)
        {
            return pointer < _file._chunks.Count ? _file._chunks[pointer] : null;
        }

        internal void Set(IRedBaseHandle handle, IRedClass cls)
        {
            RemoveHandle(handle);

            var index = _file._chunks.IndexOf(cls);
            if (index == -1)
            {
                _file._chunks.Add(cls);
                index = _file._chunks.Count - 1;
            }

            handle.Pointer = index;
            RegisterHandle(handle);
        }

        internal void RemoveHandle(IRedBaseHandle cHandle)
        {
            if (!_pointers.Contains(cHandle.Pointer))
            {
                throw new Exception();
            }

            _refDict[cHandle.Pointer].Handles.Remove(cHandle);
            if (_refDict[cHandle.Pointer].Handles.Count == 0)
            {
                _refDict.Remove(cHandle.Pointer);

                RemoveChunk(cHandle.Pointer);
            }
        }

        private void RemoveChunk(int index)
        {
            for (int i = index + 1; i < _file._chunks.Count; i++)
            {
                for (int j = 0; j < _refDict[i].Handles.Count; j++)
                {
                    _refDict[i].Handles[j].Pointer--;
                }
            }
            _file._chunks.RemoveAt(index);
            foreach (var chunkRef in _refDict)
            {
                if (chunkRef.Value.Pointer > index)
                {
                    chunkRef.Value.Pointer--;
                }
            }
        }

        private class ChunkRef
        {
            public int Pointer { get; set; }
            public List<IRedBaseHandle> Handles { get; } = new();

            public ChunkRef(int pointer)
            {
                Pointer = pointer;
            }
        }
    }
}
