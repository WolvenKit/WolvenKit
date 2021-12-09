using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using DynamicData;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;

namespace WolvenKit.ViewModels.Shell
{
    public class ChunkViewModel : ReactiveObject, ISelectableTreeViewItemModel
    {
        private readonly IRedType _data;
        private ObservableCollection<ChunkViewModel> properties;

        #region Constructors

        public ChunkViewModel(IRedType export)
        {
            _data = export;
        }

        public ChunkViewModel(string name, IRedType export)
        {
            propertyName = name;
            _data = export;
        }
        public ChunkViewModel(string name, IRedType export, ChunkViewModel parent)
        {
            propertyName = name;
            _data = export;
            Parent = parent;
        }

        #endregion Constructors

        #region Properties

        public IRedType Data => _data;

        public ChunkViewModel Parent { get; }

        public ObservableCollection<ChunkViewModel> Properties
        {
            get
            {
                if (properties == null)
                {
                    properties = new ObservableCollection<ChunkViewModel>();
                    try
                    {
                        if (_data is IRedArray ary)
                        {
                            for (int i = 0; i < ary.Count; i++)
                            {
                                properties.Add(new ChunkViewModel(i.ToString(), (IRedType)ary[i], this));
                            }
                        }
                        else if (_data is RedBaseClass redClass)
                        {
                            var eti = RedReflection.GetTypeInfo(_data.GetType());
                            eti.PropertyInfos.ForEach((pi) =>
                            {
                                var instance = pi.GetValue(redClass);
                                object value;
                                if (instance is IRedBaseHandle handle)
                                {
                                    value = handle.File.Chunks[handle.Pointer];
                                }
                                else
                                {
                                    value = instance;
                                }
                                properties.Add(new ChunkViewModel(pi.Name, (IRedType)value, this));
                            });

                        }
                        else if (_data is SerializationDeferredDataBuffer sddb)
                        {
                            if (sddb.File is CR2WFile cR2WFile)
                            {
                                var chunks = cR2WFile.Buffers[sddb.Pointer].Chunks;
                                for (int i = 0; i < chunks.Count; i++)
                                {
                                    properties.Add(new ChunkViewModel(i.ToString(), chunks[i], this));
                                }
                            }
                        }
                        else if (_data is DataBuffer db)
                        {
                            if (db.File is CR2WFile cR2WFile)
                            {
                                var chunks = cR2WFile.Buffers[db.Pointer].Chunks;
                                for (int i = 0; i < chunks.Count; i++)
                                {
                                    properties.Add(new ChunkViewModel(i.ToString(), chunks[i], this));
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }

                return properties;
            }
            set
            {

            }
        }

        [Reactive] public bool IsSelected { get; set; }

        [Reactive] public bool IsExpanded { get; set; }

        public string propertyName { get; }
        public string Name { get
            {
                if (propertyName != null)
                {
                    return propertyName;
                }
                return _data.GetType().Name;
            }
            set
            {

            }
        }

        public string Type { get
            {
                if (_data != null)
                {
                    return _data.GetType().Name;
                }
                var propInfo = RedReflection.GetPropertyByRedName(Parent.Data.GetType(), propertyName);
                return propInfo?.RedName ?? "null";
            }
        }

        public bool IsInArray { get
            {
                return Parent != null && (Parent.Data is IRedArray || Parent.Data is DataBuffer);
            }
        }

        public string Value {
            get {
                if (_data is IRedString cn)
                {
                    return cn.GetValue();
                }
                else if (_data is IRedArray ry)
                {
                    return $"Array: {ry.InnerType.Name} [{ry.Count}]";
                }
                else if (_data is IRedHandle hnd)
                {
                    return $"Handle: {hnd.InnerType?.Name ?? "?"}";
                }
                else if (_data != null)
                {
                    return Convert.ToString(_data);
                }
                else
                {
                    return "null";
                }
            }
            set
            {

            }
        }

        public string Extension
        {
            get
            {
                if (_data == null)
                {
                    return "Error";
                }
                if (_data is IRedInteger)
                {
                    return "SymbolNumeric";
                }
                if (_data is IRedString)
                {
                    return "SymbolString";
                }
                if (_data is IRedArray)
                {
                    return "SymbolArray";
                }
                if (_data is IRedEnum)
                {
                    return "SymbolEnum";
                }
                if (_data is CBool)
                {
                    return "SymbolBoolean";
                }
                if (_data is IRedHandle)
                {
                    return "References";
                }
                if (_data is DataBuffer)
                {
                    return "GroupByRefType";
                }
                if (typeof(CResourceAsyncReference<>).IsAssignableFrom(_data?.GetType() ?? null))
                {
                    return "RepoPull";
                }
                return "SymbolClass";
            }
        }

        #endregion Properties
    }
}
