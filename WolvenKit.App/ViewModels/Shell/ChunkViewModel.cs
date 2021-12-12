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
using System.Windows.Input;
using WolvenKit.Functionality.Commands;
using static WolvenKit.RED4.Types.RedReflection;

namespace WolvenKit.ViewModels.Shell
{
    public class ChunkViewModel : ReactiveObject, ISelectableTreeViewItemModel
    {
        private IRedType _data;
        private ObservableCollection<ChunkViewModel> properties;

        #region Constructors

        public ChunkViewModel(IRedType export)
        {
            _data = export;
            OpenRefCommand = new DelegateCommand<IRedRef>(p => ExecuteOpenRef(p), CanOpenRef);
        }

        public ChunkViewModel(string name, IRedType export) : this(export)
        {
            propertyName = name;
        }

        public ChunkViewModel(string name, IRedType export, ChunkViewModel parent) : this(name, export)
        {
            Parent = parent;
        }

        #endregion Constructors

        #region Properties

        public IRedType Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

        public ChunkViewModel Parent { get; }

        public IRedType PropertyGridData
        {
            get
            {
                try
                {
                    IRedType data;
                    if (Properties.Count == 0 && !PropertyType.IsAssignableTo(typeof(IRedArray)))
                    {
                        data = Parent?.Data ?? null;
                    }
                    else
                    {
                        data = Data;
                    }

                    if (data is IRedBaseHandle handle)
                    {
                        return handle?.File?.Chunks[handle.Pointer] ?? null;
                    }
                    else
                    {
                        return data;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }

        public ObservableCollection<ChunkViewModel> Properties
        {
            get
            {
                if (properties == null)
                {
                    properties = new ObservableCollection<ChunkViewModel>();
                    try
                    {
                        var obj = _data;
                        if (_data is IRedBaseHandle handle)
                        {
                            obj = handle.File.Chunks[handle.Pointer];
                        }
                        if (obj is IRedArray ary)
                        {
                            for (int i = 0; i < ary.Count; i++)
                            {
                                properties.Add(new ChunkViewModel(i.ToString(), (IRedType)ary[i], this));
                            }
                        }
                        else if (obj is RedBaseClass redClass)
                        {
                            var pis = GetTypeInfo(redClass.GetType(), true).PropertyInfos;
                            pis.Sort((a, b) => a.Name.CompareTo(b.Name));
                            pis.ForEach((pi) =>
                            {
                                IRedType value;
                                if (pi.RedName == null)
                                {
                                    value = (IRedType)redClass.GetType().GetProperty(pi.Name).GetValue(redClass, null);
                                }
                                else
                                {
                                    value = (IRedType)pi.GetValue(redClass);
                                }
                                properties.Add(new ChunkViewModel(pi.Name, value, this));
                            });
                        }
                        else if (obj is SerializationDeferredDataBuffer sddb)
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
                        else if (obj is DataBuffer db)
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
                        //throw;
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
                //if (propertyName != null)
                //{
                return propertyName;
                //}
                //return _data.GetType().Name;
            }
            set
            {

            }
        }

        public int Level { get
            {
                if (Parent == null)
                {
                    return 0;
                }
                else if (Parent.Parent == null)
                {
                    return 1;
                }
                else if (Parent.Parent.Parent == null)
                {
                    return 2;
                }
                else if (Parent.Parent.Parent.Parent == null)
                {
                    return 3;
                }
                else if (Parent.Parent.Parent.Parent.Parent == null)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        public Type PropertyType
        {
            get
            {
                var type = _data?.GetType() ?? null;
                if (type == null)
                {
                    var parent = Parent.Data;
                    if (Parent.PropertyType == typeof(IRedBaseHandle))
                    {
                        var handle = (IRedBaseHandle)parent;
                        parent = handle.File.Chunks[handle.Pointer];
                    }
                    var propInfo = RedReflection.GetPropertyByName(parent.GetType(), propertyName) ?? null;
                    type = propInfo?.Type ?? null;
                }
                return type;
            }
        }

        public string Type
        {
            get
            {
                if (PropertyType == typeof(IRedBaseHandle))
                {
                    var handle = (IRedBaseHandle)_data;
                    return "Handle: " + (handle?.File?.Chunks[handle.Pointer]?.GetType().Name ?? "null");
                }
                return PropertyType?.Name ?? "null";
            }
        }

        public bool IsInArray { get
            {
                return Parent != null && (Parent.Data is IRedArray || Parent.Data is DataBuffer || Parent.Data is SerializationDeferredDataBuffer);
            }
        }

        public string Value {
            get {
                if (_data == null)
                {
                    return "null";
                }
                else if (PropertyType.IsAssignableTo(typeof(IRedString)))
                {
                    var value = (IRedString)_data;
                    if (value.GetValue() == "")
                    {
                        return "null";
                    }
                    else
                    {
                        return value.GetValue();
                    }
                }
                else if (PropertyType.IsAssignableTo(typeof(IRedArray)))
                {
                    var value = (IRedArray)_data;
                    return $"Array: {value.InnerType.Name} [{value.Count}]";
                }
                else if (PropertyType.IsAssignableTo(typeof(IRedBaseHandle)))
                {
                    var value = (IRedBaseHandle)_data;
                    return $"Handle: {value.InnerType.Name}";
                }
                else if (PropertyType.IsAssignableTo(typeof(IRedEnum)))
                {
                    var value = (IRedEnum)_data;
                    return value.ToEnumString();
                }
                else if (PropertyType.IsAssignableTo(typeof(IRedBitField)))
                {
                    var value = (IRedBitField)_data;
                    return value.ToBitFieldString();
                }
                else if (PropertyType.IsAssignableTo(typeof(CBool)))
                {
                    var value = (CBool)_data;
                    return value ? "True" : "False";
                }
                else if (PropertyType.IsAssignableTo(typeof(CRUID)))
                {
                    var value = (CRUID)_data;
                    return ((ulong)value).ToString();
                }
                else if (PropertyType.IsAssignableTo(typeof(CUInt64)))
                {
                    var value = (CUInt64)_data;
                    return ((ulong)value).ToString();
                }
                else if (PropertyType.IsAssignableTo(typeof(IRedInteger)))
                {
                    var value = (IRedInteger)_data;
                    return (value switch {
                        CUInt8 uint64 => (float)uint64,
                        CInt8 uint64 => (float)uint64,
                        CInt16 uint64 => (float)uint64,
                        CUInt16 uint64 => (float)uint64,
                        CInt32 uint64 => (float)uint64,
                        CUInt32 uint64 => (float)uint64,
                        CInt64 uint64 => (float)uint64,
                        _ => throw new ArgumentOutOfRangeException(nameof(value)),
                    }).ToString();
                }
                else if (PropertyType.IsAssignableTo(typeof(FixedPoint)))
                {
                    var value = (FixedPoint)_data;
                    return ((float)value).ToString("R");
                }
                else if (PropertyType.IsAssignableTo(typeof(IRedPrimitive<float>)))
                {
                    var value = (IRedPrimitive)_data;
                    return ((float)(CFloat)value).ToString("R");
                }
                else if (PropertyType.IsAssignableTo(typeof(IRedRef)))
                {
                    var value = (IRedRef)_data;
                    if (value.DepotPath != "")
                    {
                        return value.DepotPath;
                    }
                    else
                    {
                        return "null";
                    }
                }
                else
                {
                    return PropertyType?.Name ?? "null";
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
                if (PropertyType == null)
                {
                    return "Error";
                }
                if (PropertyType.IsAssignableTo(typeof(IRedInteger)))
                {
                    return "SymbolNumeric";
                }
                if (PropertyType.IsAssignableTo(typeof(IRedPrimitive<float>)))
                {
                    return "SymbolNumeric";
                }
                if (PropertyType.IsAssignableTo(typeof(IRedString)))
                {
                    return "SymbolString";
                }
                if (PropertyType.IsAssignableTo(typeof(IRedArray)))
                {
                    return "SymbolArray";
                }
                if (PropertyType.IsAssignableTo(typeof(IRedEnum)))
                {
                    return "SymbolEnum";
                }
                if (PropertyType.IsAssignableTo(typeof(IRedRef)))
                {
                    return "FileSymlinkFile";
                }
                if (PropertyType.IsAssignableTo(typeof(IRedBitField)))
                {
                    return "SymbolEnum";
                }
                if (PropertyType.IsAssignableTo(typeof(CBool)))
                {
                    return "SymbolBoolean";
                }
                if (PropertyType.IsAssignableTo(typeof(IRedBaseHandle)))
                {
                    return "References";
                }
                if (PropertyType.IsAssignableTo(typeof(DataBuffer)) || PropertyType.IsAssignableTo(typeof(SerializationDeferredDataBuffer)))
                {
                    return "GroupByRefType";
                }
                if (PropertyType.IsAssignableTo(typeof(CResourceAsyncReference<>)) || PropertyType.IsAssignableTo(typeof(CResourceReference<>)))
                {
                    return "RepoPull";
                }
                if (PropertyType.IsAssignableTo(typeof(IRedPrimitive)))
                {
                    return "DebugBreakpointDataUnverified";
                }
                if (PropertyType.IsAssignableTo(typeof(WorldTransform)))
                {
                    return "Compass";
                }
                if (PropertyType.IsAssignableTo(typeof(WorldPosition)))
                {
                    return "Move";
                }
                if (PropertyType.IsAssignableTo(typeof(Quaternion)))
                {
                    return "IssueReopened";
                }
                if (PropertyType.IsAssignableTo(typeof(CColor)))
                {
                    return "SymbolColor";
                }
                return "SymbolClass";
            }
        }

        #endregion Properties

        public bool CanBeDroppedOn(ChunkViewModel target)
        {
            return PropertyType == target.PropertyType;
        }

        public ICommand OpenRefCommand { get; private set; }
        private bool CanOpenRef(IRedRef redRef) => redRef != null && redRef.DepotPath != null;
        private void ExecuteOpenRef(IRedRef redRef)
        {
            var depotpath = redRef.DepotPath;
            //var key = FNV1A64HashAlgorithm.HashString(depotpath);

            //var _gameControllerFactory = Locator.Current.GetService<IGameControllerFactory>();
            //var _archiveManager = Locator.Current.GetService<IArchiveManager>();

            //if (_archiveManager.Lookup(key).HasValue)
            //{
            //    _gameControllerFactory.GetController().AddToMod(key);
            //}
        }

    }
}
