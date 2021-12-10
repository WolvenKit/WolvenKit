using System;
using System.Collections.Generic;
using System.Linq;

namespace WolvenKit.RED4.Types
{
    public sealed class HandleManager
    {
        private Red4File _file;

        private readonly List<ChunkRef> _refList = new();

        public HandleManager(Red4File red4File)
        {
            _file = red4File;
        }

        internal void RegisterHandle(IRedBaseHandle handle)
        {
            if (_refList.All(x => x.Pointer != handle.Pointer))
            {
                _refList.Add(new ChunkRef(handle.Pointer));
            }
            _refList.First(x => x.Pointer == handle.Pointer).Handles.Add(handle);
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
            var chunkRef = _refList.FirstOrDefault(x => x.Pointer == cHandle.Pointer);
            if (chunkRef == null)
            {
                throw new Exception();
            }

            chunkRef.Handles.Remove(cHandle);
            if (chunkRef.Handles.Count == 0)
            {
                _refList.Remove(chunkRef);

                RemoveChunk(cHandle.Pointer);
            }
        }

        private void RemoveChunk(int index)
        {
            for (int i = index + 1; i < _file._chunks.Count; i++)
            {
                var chunkRef = _refList.FirstOrDefault(x => x.Pointer == i);
                for (int j = 0; j < chunkRef.Handles.Count; j++)
                {
                    chunkRef.Handles[j].Pointer--;
                }
            }
            _file._chunks.RemoveAt(index);
            foreach (var chunkRef in _refList)
            {
                if (chunkRef.Pointer > index)
                {
                    chunkRef.Pointer--;
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
