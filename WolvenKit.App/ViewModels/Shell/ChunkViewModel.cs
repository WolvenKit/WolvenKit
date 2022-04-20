using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Windows.Input;
using DynamicData;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.RED4;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.Documents;
using static WolvenKit.RED4.Types.RedReflection;

namespace WolvenKit.ViewModels.Shell
{
    public class ChunkViewModel : ReactiveObject, ISelectableTreeViewItemModel
    {
        public bool PropertiesLoaded;

        public ObservableCollectionExtended<ChunkViewModel> Properties { get; } = new();

        public ObservableCollectionExtended<ChunkViewModel> SelfList { get; set; }

        public ObservableCollectionExtended<ChunkViewModel> TempList { get; set; }

        public ObservableCollectionExtended<ChunkViewModel> TVProperties
        {
            get
            {
                if (PropertiesLoaded)
                {
                    return Properties;
                }
                else
                {
                    return TempList;
                }
            }
        }

        public ObservableCollectionExtended<ChunkViewModel> DisplayProperties
        {
            get
            {
                if (MightHaveChildren())
                {
                    return Properties;
                }
                else
                {
                    return SelfList;
                }
            }
        }

        [Reactive] public string Value { get; private set; }
        [Reactive] public string Descriptor { get; private set; }
        [Reactive] public bool IsDefault { get; private set; }
        [Reactive] public bool IsReadOnly { get; set; }

        #region Constructors

        public ChunkViewModel(ChunkViewModel parent = null)
        {
            Parent = parent;
        }

        public ChunkViewModel(IRedType export, ChunkViewModel parent = null, string name = null, bool lazy = false)
        {
            Data = export;
            Parent = parent;
            propertyName = name;

            SelfList = new ObservableCollectionExtended<ChunkViewModel>(new[] { this });

            if (HasChildren())
            {
                TempList = new ObservableCollectionExtended<ChunkViewModel>(new[] { new ChunkViewModel(this) });
            }

            this.WhenAnyValue(x => x.IsSelected)
                .Where(x => IsSelected && !PropertiesLoaded)
                .Subscribe(x => CalculateProperties());

            this.WhenAnyValue(x => x.IsExpanded)
                .Where(x => IsExpanded && !PropertiesLoaded)
                .Subscribe(x => CalculateProperties());

            CalculateValue();
            CalculateDescriptor();
            CalculateIsDefault();

            this.WhenAnyValue(x => x.Data).Skip(1)
                .Subscribe((_) =>
                {
                    CalculateValue();
                    CalculateDescriptor();
                    CalculateIsDefault();

                    if (Parent != null)
                    {

                        if (Parent.Data is IRedArray arr)
                        {
                            var index = int.Parse(Name);
                            if (index != -1)
                            {
                                arr[index] = Data;
                                Tab.File.SetIsDirty(true);
                                Parent.NotifyChain("Data");
                            }
                        }

                        if (propertyName != null)
                        {
                            var parentType = Parent.PropertyType;
                            var parentData = Parent.Data;
                            if (Parent.Data is IRedBaseHandle handle)
                            {
                                parentData = handle.GetValue();
                                parentType = handle.GetValue().GetType();
                            }

                            if (parentData is RedBaseClass rbc)
                            {
                                //if (rbc.HasProperty(propertyName) && rbc.GetProperty(propertyName) != Data)
                                //{
                                    rbc.SetProperty(propertyName, Data);
                                    Tab.File.SetIsDirty(true);
                                    Parent.NotifyChain("Data");
                                //}
                            }
                            else
                            {
                                var pi = parentData.GetType().GetProperty(propertyName);
                                if (pi != null)
                                {
                                    pi.SetValue(parentData, Data);
                                    Tab.File.SetIsDirty(true);
                                    Parent.NotifyChain("Data");
                                }
                            }
                        }

                        Parent.CalculateDescriptor();
                    }
                });

            //DoSubscribe();

            OpenRefCommand = new DelegateCommand(_ => ExecuteOpenRef(), _ => CanOpenRef());
            AddRefCommand = new DelegateCommand(_ => ExecuteAddRef(), _ => CanAddRef());
            ExportChunkCommand = new DelegateCommand(_ => ExecuteExportChunk(), _ => CanExportChunk());
            AddItemToArrayCommand = new DelegateCommand(_ => ExecuteAddItemToArray(), _ => CanAddItemToArray());
            AddHandleCommand = new DelegateCommand(_ => ExecuteAddHandle(), _ => CanAddHandle());
            AddItemToCompiledDataCommand = new DelegateCommand(_ => ExecuteAddItemToCompiledData(), _ => CanAddItemToCompiledData());
            DeleteItemCommand = new DelegateCommand(_ => ExecuteDeleteItem(), _ => CanDeleteItem());
            DeleteAllCommand = new DelegateCommand(_ => ExecuteDeleteAll(), _ => CanDeleteAll());
            OpenChunkCommand = new DelegateCommand(_ => ExecuteOpenChunk(), _ => CanOpenChunk());
            CopyChunkCommand = new DelegateCommand(_ => ExecuteCopyChunk(), _ => CanCopyChunk());
            DuplicateChunkCommand = new DelegateCommand(_ => ExecuteDuplicateChunk(), _ => CanDuplicateChunk());
            PasteChunkCommand = new DelegateCommand(_ => ExecutePasteChunk(), _ => CanPasteChunk());
        }

        public ChunkViewModel(IRedType export, RDTDataViewModel tab) : this(export)
        {
            _tab = tab;
            IsExpanded = true;
            //Data = export;
            //if (!PropertiesLoaded)
            //{
            //CalculateProperties();
            //}
            //TVProperties.AddRange(Properties);
            //this.RaisePropertyChanged("Data");
            this.WhenAnyValue(x => x.Data).Skip(1).Subscribe((x) =>
            {
                Tab.File.SetIsDirty(true);
            });
        }

        #endregion Constructors

        public void NotifyChain(string property)
        {
            this.RaisePropertyChanged(property);
            if (Parent != null)
            {
                Parent.NotifyChain(property);
            }
        }

        private ObservableCollection<ISelectableTreeViewItemModel> SplitProperties(ObservableCollection<ChunkViewModel> locations, int nSize = 100)
        {
            if (locations == null)
            {
                return null;
            }

            if (locations.Count < nSize)
            {
                return new ObservableCollection<ISelectableTreeViewItemModel>(locations);
            }

            var list = new ObservableCollection<ISelectableTreeViewItemModel>();

            for (var i = 0; i < locations.Count; i += nSize)
            {
                var size = Math.Min(nSize, locations.Count - i);
                list.Add(new GroupedChunkViewModel($"[{i}-{i + size - 1}]", locations.Skip(i).Take(size)));
            }

            return list;
        }

        public bool MightHaveChildren()
        {
            return HasChildren() || IsArray;
        }

        public bool HasChildren() => PropertyCount > 0;

        #region Properties

        private readonly RDTDataViewModel _tab;

        public RDTDataViewModel Tab
        {
            get
            {
                if (_tab != null)
                {
                    return _tab;
                }

                return Parent.Tab;
            }
        }

        [Reactive] public IRedType Data { get; set; }

        private IRedType _resolvedDataCache;

        public IRedType ResolvedData
        {
            get
            {
                if (_resolvedDataCache == null)
                {
                    var data = Data;
                    if (Data is IRedBaseHandle handle)
                    {
                        data = handle.GetValue();
                    }
                    else if (Data is CVariant v)
                    {
                        data = v.Value;
                    }
                    else if (Data is TweakDBID tdb && PropertiesLoaded)
                    {
                        data = Locator.Current.GetService<TweakDBService>().GetFlat(tdb);
                        if (data == null)
                        {
                            data = Locator.Current.GetService<TweakDBService>().GetRecord(tdb);
                        }
                    }
                    else if (Data is DataBuffer db && db.Buffer.Data is IRedType irt)
                    {
                        data = irt;
                    }
                    _resolvedDataCache = data;
                    //this.RaisePropertyChanged("ResolvedData");
                }
                return _resolvedDataCache;
            }
            set
            {
                _resolvedDataCache = null;
            }
        }

        public ChunkViewModel Parent { get; set; }

        public void CalculateProperties()
        {
            if (PropertiesLoaded)
            {
                return;
            }

            PropertiesLoaded = true;
            this.RaisePropertyChanged("ResolvedData");

            Properties.Clear();

            var isreadonly = false;
            if (Parent != null)
            {
                isreadonly = Parent.IsReadOnly;
            }
            var obj = Data;
            if (obj is IRedBaseHandle handle)
            {
                obj = handle.GetValue();
            }
            if (obj is CVariant v)
            {
                obj = v.Value;
            }
            if (obj is TweakDBID tdb)
            {
                obj = Locator.Current.GetService<TweakDBService>().GetFlat(tdb);
                if (obj != null)
                {
                    Properties.Add(new ChunkViewModel(obj, this, "Value")
                    {
                        IsReadOnly = true
                    });
                    this.RaisePropertyChanged("TVProperties");
                    return;
                }
                else
                {
                    obj = Locator.Current.GetService<TweakDBService>().GetRecord(tdb);
                }
                isreadonly = true;
                //var record = Locator.Current.GetService<TweakDBService>().GetRecord(tdb);
                //if (record != null)
                //{
                //    Properties.Add(new ChunkViewModel(record, this, "record"));
                //}
            }
            else if (obj is BaseStringType str)
            {
                var s = (string)str;
                if (s != null && s.StartsWith("LocKey#") && ulong.TryParse(s.Substring(7), out var locKey))
                {
                    obj = Locator.Current.GetService<LocKeyService>().GetEntry(locKey);
                    isreadonly = true;
                }
            }
            else if (obj is gamedataLocKeyWrapper locKey)
            {
                obj = Locator.Current.GetService<LocKeyService>().GetEntry(locKey);
                isreadonly = true;
            }

            if (obj is IRedArray ary)
            {
                for (var i = 0; i < PropertyCount; i++)
                {
                    Properties.Add(new ChunkViewModel((IRedType)ary[i], this, null)
                    {
                        IsReadOnly = isreadonly
                    });
                }
            }
            else if (obj is CKeyValuePair kvp)
            {
                for (var i = 0; i < PropertyCount; i++)
                {
                    if (i == 0)
                    {
                        Properties.Add(new ChunkViewModel(kvp.Key, this, "key")
                        {
                            IsReadOnly = isreadonly
                        });
                    }
                    else
                    {
                        Properties.Add(new ChunkViewModel(kvp.Value, this, "value")
                        {
                            IsReadOnly = isreadonly
                        });
                    }
                }
            }
            else if (obj is inkWidgetReference iwr)
            {
                // need to add XPath somewhere in the data structure
                Properties.Add(new ChunkViewModel((CString)"TODO", this));
            }
            else if (obj is RedBaseClass redClass)
            {
                var pis = GetTypeInfo(redClass.GetType()).PropertyInfos.Sort((a, b) => a.Name.CompareTo(b.Name));

                var dps = redClass.GetDynamicPropertyNames();
                dps.Sort();

                for (var i = 0; i < pis.Count + dps.Count; i++)
                {
                    if (pis.Count > i)
                    {
                        var name = !string.IsNullOrEmpty(pis[i].RedName) ? pis[i].RedName : pis[i].Name;

                        Properties.Add(new ChunkViewModel(redClass.GetProperty(name), this, pis[i].RedName)
                        {
                            IsReadOnly = isreadonly
                        });
                    }
                    else
                    {
                        Properties.Add(new ChunkViewModel(redClass.GetProperty(dps[i - pis.Count]), this, dps[i - pis.Count])
                        {
                            IsReadOnly = isreadonly
                        });
                    }
                }
            }
            else if (obj is SerializationDeferredDataBuffer sddb)
            {
                if (sddb.Data is Package04 p4)
                {
                    for (var i = 0; i < PropertyCount; i++)
                    {
                        Properties.Add(new ChunkViewModel(p4.Chunks[i], this, null)
                        {
                            IsReadOnly = isreadonly
                        });
                    }
                }
                else if (sddb.Data != null)
                {
                    var pis = sddb.Data.GetType().GetProperties();
                    foreach (var pi in pis)
                    {
                        var value = pi.GetValue(sddb.Data);
                        if (value is IRedType irt)
                        {
                            Properties.Add(new ChunkViewModel(irt, this, pi.Name)
                            {
                                IsReadOnly = isreadonly
                            });
                        }
                    }
                }
            }
            else if (obj is SharedDataBuffer sdb)
            {
                if (sdb.Data is Package04 p42)
                {
                    for (var i = 0; i < PropertyCount; i++)
                    {
                        Properties.Add(new ChunkViewModel(p42.Chunks[i], this, null)
                        {
                            IsReadOnly = isreadonly
                        });
                    }
                }
                if (sdb.File is CR2WFile cr2)
                {
                    //var chunks = cr2.Chunks;
                    //for (int i = 0; i < chunks.Count; i++)
                    //{
                    //    properties.Add(i, new ChunkViewModel(i, chunks[i], this));
                    //}
                    Properties.Add(new ChunkViewModel(cr2.RootChunk, this)
                    {
                        IsReadOnly = isreadonly
                    });
                }
                if (sdb.Data is IParseableBuffer ipb)
                {
                    Properties.Add(new ChunkViewModel(ipb.Data, this)
                    {
                        IsReadOnly = isreadonly
                    });
                }
            }
            else if (obj is DataBuffer db)
            {
                if (db.Data is Package04 p43)
                {
                    for (var i = 0; i < PropertyCount; i++)
                    {
                        Properties.Add(new ChunkViewModel(p43.Chunks[i], this, null)
                        {
                            IsReadOnly = isreadonly
                        });
                    }
                }
                else if (db.Data is CR2WList cl)
                {
                    for (var i = 0; i < PropertyCount; i++)
                    {
                        Properties.Add(new ChunkViewModel(cl.Files[i].RootChunk, this, null)
                        {
                            IsReadOnly = isreadonly
                        });
                    }
                }
                else if (db.Data is IList list)
                {
                    foreach (var thing in list)
                    {
                        Properties.Add(new ChunkViewModel((IRedType)thing, this, null)
                        {
                            IsReadOnly = isreadonly
                        });
                    }
                }
                else if (db.Data != null)
                {
                    var pis = db.Data.GetType().GetProperties();
                    foreach (var pi in pis)
                    {
                        var value = pi.GetValue(db.Data);
                        if (value is IRedType irt)
                        {
                            Properties.Add(new ChunkViewModel(irt, this, pi.Name)
                            {
                                IsReadOnly = isreadonly
                            });
                        }
                    }
                }
            }
            //else if (Data is TweakXLFile)
            // fallback for non-RTTI data
            else if (Data != null)
            {
                if (Data is IBrowsableDictionary ibd)
                {
                    var pns = ibd.GetPropertyNames();
                    foreach (var name in pns)
                    {
                        Properties.Add(new ChunkViewModel((IRedType)ibd.GetPropertyValue(name), this, name)
                        {
                            IsReadOnly = isreadonly
                        });
                    }
                }
                else if (Data is IList list)
                {
                    foreach (var thing in list)
                    {
                        Properties.Add(new ChunkViewModel((IRedType)thing, this, null)
                        {
                            IsReadOnly = isreadonly
                        });
                    }
                }
                else if (Data is Dictionary<string, object> dict)
                {
                    foreach (var (name, thing) in dict)
                    {
                        Properties.Add(new ChunkViewModel((IRedType)thing, this, name)
                        {
                            IsReadOnly = isreadonly
                        });
                    }
                }
                else
                {
                    var pis = Data.GetType().GetProperties();
                    foreach (var pi in pis)
                    {
                        var value = Data != null ? pi.GetValue(Data) : null;
                        if (value is IRedType irt)
                        {
                            Properties.Add(new ChunkViewModel(irt, this, pi.Name)
                            {
                                IsReadOnly = isreadonly
                            });
                        }
                    }
                    if (Data is worldNodeData sst && Tab.Chunks[0].Data is worldStreamingSector wss)
                    {
                        Properties.Add(new ChunkViewModel(wss.Nodes[sst.NodeIndex], this, "Node")
                        {
                            IsReadOnly = isreadonly
                        });
                    }
                }
            }
            this.RaisePropertyChanged("TVProperties");
        }

        [Reactive] public bool IsSelected { get; set; }

        [Reactive] public bool IsDeleteReady { get; set; }

        [Reactive] public bool IsExpanded { get; set; }

        [Reactive] public bool IsHandled { get; set; }

        public string propertyName { get; }

        private string _name;

        public string Name
        {
            get
            {
                if (_name == null)
                {
                    var name = propertyName;
                    if (IsInArray)
                    {
                        name = Parent.GetIndexOf(this).ToString();
                    }
                    else if (name == null && Data is IBrowsableType ibt)
                    {
                        name = ibt.GetBrowsableName();
                    }
                    _name = name;
                    //this.RaisePropertyChanged("Name");
                }
                return _name;
            }
            set
            {
                _name = null;
            }
        }

        private void CalculateIsDefault()
        {
            IsDefault = Data == null;

            if (Parent != null && propertyName != null && Data is not IRedBaseHandle)
            {
                var epi = GetPropertyByRedName(Parent.ResolvedPropertyType, propertyName);
                if (epi != null)
                {
                    //IsDefault = IsDefault(Parent.ResolvedPropertyType, epi, Data);
                    IsDefault = IsDefault(Parent.ResolvedPropertyType, epi, ResolvedData);
                }
            }
        }

        public int GetIndexOf(ChunkViewModel child)
        {
            if (ResolvedData is IList ary)
            {
                var index = 0;
                foreach (var item in ary)
                {
                    if (item.GetHashCode() == child.Data.GetHashCode())
                    {
                        if (!PropertiesLoaded || Properties[index].GetHashCode() == child.GetHashCode())
                        {
                            return index;
                        }
                    }
                    index++;
                }
            }
            else if (ResolvedData is IRedBufferPointer rbp && rbp.GetValue().Data is Package04 pkg)
            {
                var index = 0;
                foreach (var item in pkg.Chunks)
                {
                    if (item.GetHashCode() == child.Data.GetHashCode())
                    {
                        if (!PropertiesLoaded || Properties[index].GetHashCode() == child.GetHashCode())
                        {
                            return index;
                        }
                    }
                    index++;
                }
            }
            else if (ResolvedData is IRedBufferPointer rbp2 && rbp2.GetValue().Data is CR2WList cl)
            {
                var index = 0;
                foreach (var file in cl.Files)
                {
                    if (file.RootChunk.GetHashCode() == child.Data.GetHashCode())
                    {
                        if (!PropertiesLoaded || Properties[index].GetHashCode() == child.GetHashCode())
                        {
                            return index;
                        }
                    }
                    index++;
                }
            }
            return 0;
        }

        public int Level => Parent == null ? 0 : Parent.Level + 1;

        public int DetailsLevel => (IsSelected || Parent == null) ? 0 : Parent.DetailsLevel + 1;

        private Flags _flags;

        public Type PropertyType
        {
            get
            {
                var type = Data?.GetType() ?? null;
                if (Parent != null)
                {
                    var parent = Parent.Data;
                    var parentType = Parent.ResolvedPropertyType;
                    // handles aren't the true parent type of these props, so need to get that
                    //if (Parent.Data is IRedBaseHandle handle && handle != null)
                    //{
                    //    parent = handle.GetValue();
                    //    parentType = handle.GetValue().GetType();
                    //}
                    var propInfo = GetPropertyByRedName(parentType, propertyName) ?? null;
                    if (propInfo != null)
                    {
                        if (type == null || type == propInfo.Type)
                        {
                            _flags = propInfo.Flags;
                            type = propInfo.Type;
                        }
                    }
                }
                return type;
            }
        }

        public Type ResolvedPropertyType
        {
            get
            {
                if (Data is IRedBaseHandle handle)
                {
                    return handle?.GetValue()?.GetType() ?? handle.InnerType;
                }
                if (Data is CVariant v)
                {
                    return v?.Value.GetType() ?? null;
                }
                if (Data is TweakDBID tdb)
                {
                    var type = Locator.Current.GetService<TweakDBService>().GetType(tdb);
                    if (type != null)
                    {
                        return type;
                    }
                }
                if (Data is ITweakXLItem iti)
                {
                    var type = Locator.Current.GetService<TweakDBService>().GetType(iti.ID);
                    if (type != null)
                    {
                        return type;
                    }
                }
                if (Data is BaseStringType str)
                {
                    var s = (string)str;
                    if (s != null && s.StartsWith("LocKey#") && ulong.TryParse(s.Substring(7), out var _))
                    {
                        return typeof(localizationPersistenceOnScreenEntry);
                    }
                }
                if (Data is DataBuffer db && db.Data != null)
                {
                    return db.Data.GetType();
                }
                if (Data is SharedDataBuffer sdb && sdb.Data != null)
                {
                    return sdb.Data.GetType();
                }
                if (Data is SerializationDeferredDataBuffer sddb && sddb.Data != null)
                {
                    return sddb.Data.GetType();
                }
                if (Data is gamedataLocKeyWrapper)
                {
                    return typeof(localizationPersistenceOnScreenEntry);
                }
                //if (Data is IBrowsableType ibt && ibt.GetBrowsableType() is var browsableType && browsableType != null)
                //{
                //    return browsableType;
                //}
                return PropertyType;
            }
        }

        public string Type
        {
            get
            {
                if (PropertyType != null)
                {
                    var redName = GetRedTypeFromCSType(PropertyType, _flags);
                    if (redName != "")
                    {
                        return redName;
                    }
                    return PropertyType.Name;
                }
                return "null";
            }
        }

        public string ResolvedType => ResolvedPropertyType != null ? (GetTypeRedName(ResolvedPropertyType) != null ? GetTypeRedName(ResolvedPropertyType) : ResolvedPropertyType.Name) : "";

        public bool TypesDiffer => PropertyType != ResolvedPropertyType;

        public bool IsInArray => Parent != null && Parent.IsArray;

        public bool IsArray => PropertyType != null &&
                    (PropertyType.IsAssignableTo(typeof(IRedArray)) ||
                    ResolvedPropertyType.IsAssignableTo(typeof(IList)) ||
                    ResolvedPropertyType.IsAssignableTo(typeof(CR2WList)) ||
                    ResolvedPropertyType.IsAssignableTo(typeof(Package04)));

        private int _propertyCountCache = -1;

        public int PropertyCount
        {
            get
            {
                if (_propertyCountCache == -1)
                {
                    var count = 0;
                    if (ResolvedData is IRedArray ary)
                    {
                        count += ary.Count;
                    }
                    else if (ResolvedData is CKeyValuePair)
                    {
                        count += 2;
                    }
                    else if (ResolvedData is inkWidgetReference)
                    {
                        count += 1; // TODO
                    }
                    else if (Data is TweakDBID tdb)
                    {
                        // not actual
                        if (Locator.Current.GetService<TweakDBService>().Exists(tdb))
                        {
                            count += 1;
                        }
                    }
                    else if (ResolvedData is BaseStringType str)
                    {
                        var s = (string)str;
                        if (s != null && s.StartsWith("LocKey#") && ulong.TryParse(s.Substring(7), out var locKey))
                        {
                            // not actual
                            count += 1;
                        }
                    }
                    else if (ResolvedData is gamedataLocKeyWrapper locKey)
                    {
                        // not actual
                        count += 1;
                    }
                    else if (ResolvedData is RedBaseClass redClass)
                    {
                        var pis = GetTypeInfo(redClass.GetType()).PropertyInfos;
                        count += pis.Count;

                        var dps = redClass.GetDynamicPropertyNames();
                        count += dps.Count;
                    }
                    else if (ResolvedData is SerializationDeferredDataBuffer sddb)
                    {
                        if (sddb.Data is Package04 p4)
                        {
                            count += p4.Chunks.Count;
                        }
                        else if (sddb.Data != null)
                        {
                            count += sddb.Data.GetType().GetProperties().Count();
                        }
                    }
                    else if (ResolvedData is SharedDataBuffer sdb)
                    {
                        if (sdb.Data is Package04 p42)
                        {
                            count += p42.Chunks.Count;
                        }
                        if (sdb.File is CR2WFile)
                        {
                            count += 1;
                        }
                        if (sdb.Data is IParseableBuffer)
                        {
                            count += 1;  // needs refinement?
                        }
                    }
                    else if (ResolvedData is DataBuffer db)
                    {
                        if (db.Data is Package04 p43)
                        {
                            count += p43.Chunks.Count;
                        }
                        else if (db.Data is CR2WList cl)
                        {
                            count += cl.Files.Count;
                        }
                        else if (db.Data is IList list)
                        {
                            count += list.Count;
                        }
                        else if (db.Data is IParseableBuffer)
                        {
                            count += 1; // needs refinement?
                        }
                    }
                    else if (ResolvedData != null)
                    {
                        if (Data is IBrowsableDictionary ibd)
                        {
                            var pns = ibd.GetPropertyNames();
                            count += pns.Count();
                        }
                        else if (Data is IList list)
                        {
                            count += list.Count;
                        }
                        else if (Data is Dictionary<string, object> dict)
                        {
                            count += dict.Count;
                        }
                        else
                        {
                            var pis = Data.GetType().GetProperties();
                            count += pis.Count();
                        }
                        if (Data is worldNodeData)
                        {
                            count += 1;
                        }
                    }
                    _propertyCountCache = count;
                    //this.RaisePropertyChanged("PropertyCount");
                }
                return _propertyCountCache;
            }
            set
            {
                _propertyCountCache = -1;
            }
        }

        public int ArrayIndexWidth
        {
            get
            {
                var width = 0;
                if (Parent != null)
                {
                    //if (Parent.ResolvedData is IRedArray ary)
                    //{
                    //    width += 20;
                    //}
                    if (Parent.PropertyCount <= 10)
                    {
                        width += 16;
                    }
                    else if (Parent.PropertyCount <= 100)
                    {
                        width += 21;
                    }
                    else if (Parent.PropertyCount <= 1000)
                    {
                        width += 26;
                    }
                    else if (Parent.PropertyCount <= 10000)
                    {
                        width += 31;
                    }
                    else
                    {
                        width += 36;
                    }
                }
                if (PropertyType?.IsAssignableTo(typeof(IRedArray)) ?? false)
                {
                    width += 20;
                }

                return width;
            }
        }

        public string XPath
        {
            get
            {
                if (Parent == null)
                {
                    return "root";
                }
                else
                {
                    var xpath = Parent.XPath;
                    if (IsInArray)
                    {
                        xpath += $"[{Name}]";
                    }
                    else if (Name != "")
                    {
                        xpath += "." + Name;
                    }

                    return xpath;
                }
            }
        }

        private void CalculateValue()
        {
            Value = "";
            if (Data == null)
            {
                Value = "null";
            }

            if (PropertyType.IsAssignableTo(typeof(BaseStringType)))
            {
                var value = (BaseStringType)Data;
                if (value is NodeRef rn)
                {
                    if (rn.GetResolvedText() is var text && !string.IsNullOrEmpty(text))
                    {
                        Value = text;
                    }
                    else if (rn.GetRedHash() != 0)
                    {
                        Value = rn.GetRedHash().ToString();
                    }
                    else
                    {
                        Value = "null";
                    }
                }
                else
                {
                    Value = "null";
                }
                if (!string.IsNullOrEmpty(value))
                {
                    Value = value;
                    if (Value != null && Value.StartsWith("LocKey#") && ulong.TryParse(Value.Substring(7), out var key))
                    {
                        Value = "";
                        //    Value = Locator.Current.GetService<LocKeyService>().GetFemaleVariant(key);
                    }
                }
            }
            else if (PropertyType.IsAssignableTo(typeof(CByteArray)))
            {
                var ba = (byte[])(CByteArray)Data;
                Value = string.Join(" ", ba.Select(x => $"{x:X2}"));
            }
            else if (PropertyType.IsAssignableTo(typeof(LocalizationString)))
            {
                var value = (LocalizationString)Data;
                if (value.Value == "" || value.Value == null)
                {
                    Value = "null";
                }
                else
                {
                    Value = value.Value;
                }
            }
            else if (PropertyType.IsAssignableTo(typeof(IRedEnum)))
            {
                var value = (IRedEnum)Data;
                Value = value.ToEnumString();
            }
            else if (PropertyType.IsAssignableTo(typeof(IRedBitField)))
            {
                var value = (IRedBitField)Data;
                Value = value.ToBitFieldString();
            }
            //else if (PropertyType.IsAssignableTo(typeof(TweakDBID)))
            //{
            //    Value = (TweakDBID)Data.ToString();
            //    //Value = Locator.Current.GetService<TweakDBService>().GetString(value);
            //}
            else if (PropertyType.IsAssignableTo(typeof(CBool)))
            {
                var value = (CBool)Data;
                Value = value ? "True" : "False";
            }
            else if (PropertyType.IsAssignableTo(typeof(CRUID)))
            {
                var value = (CRUID)Data;
                Value = ((ulong)value).ToString();
            }
            else if (PropertyType.IsAssignableTo(typeof(CUInt64)))
            {
                var value = (CUInt64)Data;
                if (value != 0)
                {
                    Value = ((NodeRef)(ulong)value).ToString();
                }
                else
                {
                    Value = ((ulong)value).ToString();
                }
            }
            else if (PropertyType.IsAssignableTo(typeof(gamedataLocKeyWrapper)))
            {
                //var value = (gamedataLocKeyWrapper)Data;
                //Value = ((ulong)value).ToString();
                //Value = Locator.Current.GetService<LocKeyService>().GetFemaleVariant(value);
            }
            else if (PropertyType.IsAssignableTo(typeof(IRedInteger)))
            {
                var value = (IRedInteger)Data;
                Value = (value switch
                {
                    CUInt8 uint64 => uint64,
                    CInt8 uint64 => uint64,
                    CInt16 uint64 => uint64,
                    CUInt16 uint64 => uint64,
                    CInt32 uint64 => uint64,
                    CUInt32 uint64 => uint64,
                    CInt64 uint64 => (float)uint64,
                    _ => throw new ArgumentOutOfRangeException(nameof(value)),
                }).ToString("F0");
            }
            else if (PropertyType.IsAssignableTo(typeof(FixedPoint)))
            {
                var value = (FixedPoint)Data;
                Value = ((float)value).ToString("R");
            }
            else if (PropertyType.IsAssignableTo(typeof(IRedPrimitive<float>)))
            {
                var value = (IRedPrimitive)Data;
                Value = ((float)(CFloat)value).ToString("R");
            }
            else if (PropertyType.IsAssignableTo(typeof(NodeRef)))
            {
                var value = (NodeRef)Data;
                Value = value;
            }
            else if (PropertyType.IsAssignableTo(typeof(IRedRef)))
            {
                var value = (IRedRef)Data;
                if (value != null && value.DepotPath.GetResolvedText() != "")
                {
                    Value = value.DepotPath.GetResolvedText();
                }
                else
                {
                    Value = "null";
                }
            }
            else if (Data is IBrowsableType ibt)
            {
                Value = ibt.GetBrowsableValue();
            }
        }

        public void CalculateDescriptor()
        {
            Descriptor = "";
            if (PropertyType == null)
            {
                return;
            }


            if (Data is worldNodeData sst && Tab.Chunks[0].Data is worldStreamingSector wss)
            {
                Descriptor = $"[{sst.NodeIndex}] {wss.Nodes[sst.NodeIndex].Chunk.DebugName}";
                return;
            }

            if (Data is worldStreamingSectorDescriptor wssd)
            {
                Descriptor = wssd.Data.DepotPath.ToString().Replace("base\\worlds\\03_night_city\\_compiled\\default\\", "").Replace(".streamingsector", "");
                return;
            }

            if (ResolvedData is IRedArray ary)
            {
                Descriptor = $"[{ary.Count}]";
            }
            else if (ResolvedData is IRedBufferPointer rbp && rbp.GetValue().Data is Package04 pkg)
            {
                Descriptor = $"[{pkg.Chunks.Count}]";
            }
            else if (ResolvedData is IRedBufferPointer rbp2 && rbp2.GetValue().Data is CR2WList cl)
            {
                Descriptor = $"[{cl.Files.Count}]";
            }
            else if (ResolvedData is CKeyValuePair kvp)
            {
                Descriptor = kvp.Key;
            }
            else if (Data is TweakDBID tdb)
            {
                //Descriptor = Locator.Current.GetService<TweakDBService>().GetString(tdb);
                Descriptor = tdb.GetResolvedText();
                return;
            }
            else if (Data is gamedataLocKeyWrapper locKey)
            {
                Descriptor = ((ulong)locKey).ToString();
                //Value = Locator.Current.GetService<LocKeyService>().GetFemaleVariant(value);
            }
            else if (Data is BaseStringType str)
            {
                var s = (string)str;
                if (s != null && s.StartsWith("LocKey#") && ulong.TryParse(s.Substring(7), out var locKey2))
                {
                    Descriptor = ((ulong)locKey2).ToString();
                }
            }
            //if (ResolvedData is CMaterialInstance && Parent != null)
            //{
            //    if (Parent.Parent != null && Parent.Parent.Parent != null && Parent.Parent.Data is CMesh mesh)
            //    {
            //        Descriptor = mesh.MaterialEntries[int.Parse(Name)].Name;
            //    }
            //}
            else if (Data is Vector3 v3)
            {
                Descriptor = $"{v3.X}, {v3.Y}, {v3.Z}";
            }
            else if (Data is Vector4 v4)
            {
                Descriptor = $"{v4.X}, {v4.Y}, {v4.Z}, {v4.W}";
            }
            else if (Data is Quaternion q)
            {
                Descriptor = $"{q.I}, {q.J}, {q.K}, {q.R}";
            }
            if (Data is CMaterialInstance && Parent != null && Tab.File.Cr2wFile.RootChunk is CMesh mesh)
            {
                if (mesh.LocalMaterialBuffer.RawData.Data is CR2WList list)
                {
                    for (var i = 0; i < list.Files.Count; i++)
                    {
                        if (list.Files[i].RootChunk == Data)
                        {
                            if (mesh.MaterialEntries.Count > i)
                            {
                                Descriptor = mesh.MaterialEntries[i].Name;
                            }
                            break;
                        }
                    }
                }
            }
            else if (ResolvedData != null)
            {
                if (Data is IBrowsableDictionary ibd)
                {
                    var pns = ibd.GetPropertyNames();
                    Descriptor = $"[{pns.Count()}]";
                }
                else if (Data is IList list)
                {
                    Descriptor = $"[{list.Count}]";
                }
                else if (Data is Dictionary<string, object> dict)
                {
                    Descriptor = $"[{dict.Count}]";
                }
            }
            // some common "names" of classes that might be useful to display in the UI
            var propNames = new string[]
            {
                    "name",
                    "partName",
                    "slotName",
                    "hudEntryName",
                    "stateName",
                    "n",
                    "componentName",
                    "parameterName",
                    "debugName",
                    "category",
                    "entryName",
                    "className",
                    "actorName",
                    "sectorHash"
            };
            if (ResolvedData is RedBaseClass irc)
            {
                foreach (var propName in propNames)
                {
                    var prop = GetPropertyByRedName(irc.GetType(), propName);
                    if (prop != null)
                    {
                        Descriptor = irc.GetProperty(prop.RedName).ToString();
                        return;
                    }
                }
            }
            else
            {
                foreach (var propName in propNames)
                {
                    if (Data != null)
                    {
                        var prop = Data.GetType().GetProperty(propName);
                        if (prop != null)
                        {
                            Descriptor = prop.GetValue(Data).ToString();
                            return;
                        }
                    }
                }
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
                if (PropertyType.IsAssignableTo(typeof(BaseStringType)))
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
                if (PropertyType.IsAssignableTo(typeof(TweakDBID)))
                {
                    return "DebugBreakpointConditionalUnverified";
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

        public bool CanBeDroppedOn(ChunkViewModel target) => PropertyType == target.PropertyType;

        public ICommand OpenRefCommand { get; private set; }
        private bool CanOpenRef() => Data is IRedRef r && r.DepotPath != null;
        private void ExecuteOpenRef()
        {
            if (Data is IRedRef r)
            {
                //string depotpath = r.DepotPath;
                //Tab.File.OpenRefAsTab(depotpath);
                Locator.Current.GetService<AppViewModel>().OpenFileFromHash(r.DepotPath.GetRedHash());
            }
            //var key = FNV1A64HashAlgorithm.HashString(depotpath);

            //var _gameControllerFactory = Locator.Current.GetService<IGameControllerFactory>();
            //var _archiveManager = Locator.Current.GetService<IArchiveManager>();

            //if (_archiveManager.Lookup(key).HasValue)
            //{
            //    _gameControllerFactory.GetController().AddToMod(key);
            //}
        }

        public ICommand AddRefCommand { get; private set; }
        private bool CanAddRef() => Data is IRedRef r && r.DepotPath != null;
        private void ExecuteAddRef()
        {
            if (Data is IRedRef r)
            {
                //string depotpath = r.DepotPath;
                //Tab.File.OpenRefAsTab(depotpath);
                //Locator.Current.GetService<AppViewModel>().OpenFileFromDepotPath(r.DepotPath);
                var key = r.DepotPath.GetRedHash();

                var gameControllerFactory = Locator.Current.GetService<IGameControllerFactory>();
                var archiveManager = Locator.Current.GetService<IArchiveManager>();

                if (archiveManager.Lookup(key).HasValue)
                {
                    gameControllerFactory.GetController().AddToMod(key);
                }
            }
        }

        public ICommand AddHandleCommand { get; private set; }
        private bool CanAddHandle() => (PropertyType?.IsAssignableTo(typeof(IRedBaseHandle)) ?? false);
        private void ExecuteAddHandle()
        {
            var data = RedTypeManager.CreateRedType(PropertyType);
            if (data is IRedBaseHandle handle)
            {
                var existing = new ObservableCollection<string>(AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => handle.InnerType.IsAssignableFrom(p) && p.IsClass).Select(x => x.Name));
                var app = Locator.Current.GetService<AppViewModel>();
                app.SetActiveDialog(new CreateClassDialogViewModel(existing, false)
                {
                    DialogHandler = HandlePointer
                });
            }
        }

        public void HandlePointer(DialogViewModel sender)
        {
            var app = Locator.Current.GetService<AppViewModel>();
            app.CloseDialogCommand.Execute(null);
            if (sender != null)
            {
                var vm = sender as CreateClassDialogViewModel;
                var instance = RedTypeManager.Create(vm.SelectedClass);
                var data = RedTypeManager.CreateRedType(PropertyType);
                if (data is IRedBaseHandle handle)
                {
                    handle.SetValue(instance);
                    Data = data;

                    if (Parent.ResolvedData is RedBaseClass rbc)
                    {
                        rbc.SetProperty(propertyName, Data);
                    }
                    PropertyCount = -1;
                    // might not be needed
                    CalculateDescriptor();
                    PropertiesLoaded = false;
                    CalculateProperties();
                    this.RaisePropertyChanged("Data");
                    Tab.File.SetIsDirty(true);
                }
            }
        }

        public ICommand AddItemToArrayCommand { get; private set; }
        private bool CanAddItemToArray() => PropertyType.IsAssignableTo(typeof(IRedArray)) || PropertyType.IsAssignableTo(typeof(IRedLegacySingleChannelCurve));
        private void ExecuteAddItemToArray()
        {
            if (PropertyType.IsAssignableTo(typeof(IRedArray)))
            {
                if (Data == null)
                {
                    // TODO: Need info for CStatic, ...
                    return;
                }

                var arr = (IRedArray)Data;

                var innerType = arr.InnerType;
                var pointer = false;
                if (innerType.IsAssignableTo(typeof(IRedBaseHandle)))
                {
                    pointer = true;
                    innerType = innerType.GenericTypeArguments[0];
                }
                var existing = new ObservableCollection<string>(AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => innerType.IsAssignableFrom(p) && p.IsClass).Select(x => x.Name));

                // no inheritable
                if (existing.Count == 1)
                {
                    var type = arr.InnerType;
                    var newItem = RedTypeManager.CreateRedType(type);
                    if (newItem is IRedBaseHandle handle)
                    {
                        var pointee = RedTypeManager.CreateRedType(handle.InnerType);
                        handle.SetValue((RedBaseClass)pointee);
                    }
                    InsertChild(-1, newItem);
                }
                else
                {
                    var app = Locator.Current.GetService<AppViewModel>();
                    app.SetActiveDialog(new CreateClassDialogViewModel(existing, true)
                    {
                        DialogHandler = pointer ? HandleChunkPointer : HandleChunk
                    });
                }
            }

            if (PropertyType.IsAssignableTo(typeof(IRedLegacySingleChannelCurve)))
            {
                if (Data == null)
                {
                    Data = RedTypeManager.CreateRedType(PropertyType);
                }

                var curve = (IRedLegacySingleChannelCurve)Data;

                var type = curve.ElementType;
                var newItem = RedTypeManager.CreateRedType(type);
                InsertChild(-1, newItem);
            }
        }

        public ICommand AddItemToCompiledDataCommand { get; private set; }
        private bool CanAddItemToCompiledData() => ResolvedPropertyType != null && ResolvedPropertyType.IsAssignableTo(typeof(IRedBufferPointer));
        private void ExecuteAddItemToCompiledData()
        {
            if (Data == null)
            {
                Data = RedTypeManager.CreateRedType(ResolvedPropertyType);
                (Data as IRedBufferPointer).SetValue(new RED4.RedBuffer()
                {
                    Data = new Package04()
                    {
                        Chunks = new List<RedBaseClass>()
                    }
                });
            }
            if (Data is DataBuffer db2)
            {
                if (Name == "rawData" && db2.Data is null)
                {
                    db2.Buffer = RedBuffer.CreateBuffer(0, new byte[] { 0 });
                    db2.Data = new CR2WList();
                }
            }
            var db = Data as IRedBufferPointer;
            ObservableCollection<string> existing = null;
            if (db.GetValue().Data is Package04 pkg)
            {
                existing = new ObservableCollection<string>(pkg.Chunks.Select(t => t.GetType().Name).Distinct());
            }
            var app = Locator.Current.GetService<AppViewModel>();
            app.SetActiveDialog(new CreateClassDialogViewModel(existing, true)
            {
                DialogHandler = HandleChunk
            });
        }

        public void HandleChunk(DialogViewModel sender)
        {
            var app = Locator.Current.GetService<AppViewModel>();
            app.CloseDialogCommand.Execute(null);
            if (sender != null)
            {
                var vm = sender as CreateClassDialogViewModel;
                var instance = RedTypeManager.Create(vm.SelectedClass);
                InsertChild(-1, instance);
            }
        }

        public void HandleChunkPointer(DialogViewModel sender)
        {
            var app = Locator.Current.GetService<AppViewModel>();
            app.CloseDialogCommand.Execute(null);
            if (sender != null)
            {
                var vm = sender as CreateClassDialogViewModel;
                var instance = RedTypeManager.Create(vm.SelectedClass);

                var type = (Data as IRedArray).InnerType;
                var newItem = RedTypeManager.CreateRedType(type);
                if (newItem is IRedBaseHandle handle)
                {
                    handle.SetValue(instance);
                    InsertChild(-1, newItem);
                }
            }
        }

        //private void AddPropertyAtIndex(IRedType instance, int index)
        //{
        //    PropertyCount = -1;
        //    CalculateDescriptor();
        //    PropertiesLoaded = false;
        //    CalculateProperties();

        //    this.RaisePropertyChanged("Data");

        //    IsExpanded = true;

        //    foreach (var prop in Properties)
        //    {
        //        if (prop.Data.GetHashCode() == instance.GetHashCode())
        //        {
        //            prop.IsExpanded = true;
        //            Tab.SelectedChunk = prop;
        //            break;
        //        }
        //    }
        //    Tab.File.SetIsDirty(true);
        //}

        public ICommand DeleteItemCommand { get; private set; }
        private bool CanDeleteItem() => IsInArray;
        private void ExecuteDeleteItem()
        {
            Tab.SelectedChunk = Parent;
            if (Parent.Data is IRedArray ary)
            {
                ary.Remove(Data);
            }
            else if (Parent.Data is IRedLegacySingleChannelCurve curve)
            {
                curve.Remove((IRedCurvePoint)Data);
                if (curve.Count == 0)
                {
                    Parent.ResolvedData = null;
                    Parent.Data = null;
                }
            }
            else if (Parent.Data is IRedBufferPointer db && db.GetValue().Data is Package04 pkg)
            {
                if (!pkg.Chunks.Remove((RedBaseClass)Data))
                {
                    Locator.Current.GetService<ILoggerService>().Error("Unable to delete chunk");
                    return;
                }
            }
            else if (Parent.Data is IRedBufferPointer db2 && db2.GetValue().Data is CR2WList list)
            {
                list.Files.RemoveAll(x => x.RootChunk == Data);
            }
            else
            {
                Locator.Current.GetService<ILoggerService>().Error("Unknown collection - unable to delete chunk");
                return;
            }

            Tab.File.SetIsDirty(true);
            Parent.RecalulateProperties();
        }

        public ICommand DeleteAllCommand { get; private set; }
        private bool CanDeleteAll() => (IsArray && PropertyCount > 0) || (IsInArray && Parent.PropertyCount > 0);
        private void ExecuteDeleteAll()
        {
            if (IsArray)
            {
                ClearChildren();
            }
            else if (IsInArray)
            {
                Parent.ClearChildren();
            }
        }

        public void ClearChildren()
        {
            if (ResolvedData is IRedArray ary)
            {
                ary.Clear();
            }
            else if (ResolvedData is IRedLegacySingleChannelCurve curve)
            {
                ResolvedData = null;
                Data = null;
            }
            else if (ResolvedData is IRedBufferPointer db && db.GetValue().Data is Package04 pkg)
            {
                pkg.Chunks.Clear();
            }
            else if (ResolvedData is IRedBufferPointer db2 && db2.GetValue().Data is CR2WList list)
            {
                list.Files.Clear();
            }
            else
            {
                return;
            }
            IsDeleteReady = false;
            Tab.File.SetIsDirty(true);
            RecalulateProperties();
        }

        public ICommand ExportChunkCommand { get; private set; }
        private bool CanExportChunk() => PropertyCount > 0;
        private void ExecuteExportChunk()
        {
            Stream myStream;
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                FilterIndex = 2,
                FileName = Type + ".json",
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    var dto = new RedTypeDto(ResolvedData);
                    var json = RedJsonSerializer.Serialize(dto);

                    if (string.IsNullOrEmpty(json))
                    {
                        throw new SerializationException();
                    }

                    myStream.Write(json.ToCharArray().Select(c => (byte)c).ToArray());
                    myStream.Close();
                }
            }
        }

        public ICommand OpenChunkCommand { get; private set; }
        private bool CanOpenChunk() => Data is RedBaseClass && Parent != null;
        private void ExecuteOpenChunk()
        {
            if (Data is RedBaseClass cls)
            {
                Tab.File.TabItemViewModels.Add(new RDTDataViewModel(cls, Tab.File));
            }
        }

        public ICommand CopyChunkCommand { get; private set; }
        private bool CanCopyChunk() => IsInArray;
        private void ExecuteCopyChunk()
        {
            if (Data is IRedCloneable irc)
            {
                RDTDataViewModel.CopiedChunk = (IRedType)irc.DeepCopy();
            }
            else
            {
                RDTDataViewModel.CopiedChunk = Data;
            }
        }

        public ICommand DuplicateChunkCommand { get; private set; }
        private bool CanDuplicateChunk() => IsInArray;
        private void ExecuteDuplicateChunk()
        {
            if (Data is IRedCloneable irc)
            {
                Parent.InsertChild(Parent.GetIndexOf(this) + 1, (IRedType)irc.DeepCopy());
            }
            else
            {
                Parent.InsertChild(Parent.GetIndexOf(this) + 1, Data);
            }
        }

        public IRedArray ArraySelfOrParent
        {
            get
            {
                if (Parent.ResolvedData is IRedArray ira)
                {
                    return ira;
                }
                if (ResolvedData is IRedArray ira2)
                {
                    return ira2;
                }
                return null;
            }
        }

        public ICommand PasteChunkCommand { get; private set; }
        private bool CanPasteChunk() => (IsArray || IsInArray) && RDTDataViewModel.CopiedChunk != null && (ArraySelfOrParent?.InnerType.IsAssignableTo(RDTDataViewModel.CopiedChunk.GetType()) ?? true);
        private void ExecutePasteChunk()
        {
            if (RDTDataViewModel.CopiedChunk == null)
            {
                return;
            }
            if (Parent.ResolvedData is IRedArray)
            {
                if (Parent.InsertChild(Parent.GetIndexOf(this) + 1, RDTDataViewModel.CopiedChunk))
                {
                    RDTDataViewModel.CopiedChunk = null;
                }
            }
            if (ResolvedData is IRedArray)
            {
                if (InsertChild(-1, RDTDataViewModel.CopiedChunk))
                {
                    RDTDataViewModel.CopiedChunk = null;
                }
            }
        }

        public void MoveChild(int index, ChunkViewModel item)
        {
            if (item.Parent == null)
            { 
                return;
            }

            var oldParent = item.Parent;

            IList sourceList = null;
            IList destList = null;
            if (oldParent.ResolvedData is IList il)
            {
                sourceList = il;
            }
            else if (oldParent.ResolvedData is IRedBufferPointer db)
            {
                if (db.GetValue().Data is Package04 pkg)
                {
                    sourceList = (IList)pkg.Chunks;
                }
                else if (db.GetValue().Data is CR2WList cl)
                {
                    sourceList = cl.Files;
                }
            }

            if (ResolvedData is IList il2)
            {
                destList = il2;
            }
            else if (ResolvedData is IRedBufferPointer db)
            {
                if (db.GetValue().Data is Package04 pkg)
                {
                    destList = (IList)pkg.Chunks;
                }
                else if (db.GetValue().Data is CR2WList cl)
                {
                    destList = cl.Files;
                }
            }

            if (sourceList != null && destList != null)
            { 
                int oldIndex = -1, i = 0;
                foreach (var thing in sourceList)
                {
                    if (thing.GetHashCode() == item.Data.GetHashCode())
                    {
                        oldIndex = i;
                        break;
                    }
                    i++;
                }

                if (oldIndex > -1)
                {
                    sourceList.RemoveAt(oldIndex);
                    if (oldIndex < index && sourceList.GetHashCode() == destList.GetHashCode())
                    {
                        index--;
                    }
                    InsertChild(index, item.Data);
                    Tab.File.SetIsDirty(true);
                    RecalulateProperties();
                    if (sourceList.GetHashCode() != destList.GetHashCode())
                    {
                        oldParent.RecalulateProperties();
                        if (oldParent.Tab.File.GetHashCode() != Tab.File.GetHashCode())
                        {
                            oldParent.Tab.File.SetIsDirty(true);
                        }
                    }
                }
            }
        }

        public bool InsertChild(int index, IRedType item)
        {
            // update actual data
            if (ResolvedData is IRedArray ira && ira.InnerType.IsAssignableTo(item.GetType()))
            {
                var arrayType = Data.GetType().GetGenericTypeDefinition();
                if (arrayType == typeof(CArray<>) || (arrayType == typeof(CStatic<>) && ira.Count < ira.MaxSize))
                {
                    if (index == -1 || index > ira.Count)
                    {
                        index = ira.Count;
                    }
                    ira.Insert(index, item);
                }
                else
                {
                    return false;
                }
            }
            else if (ResolvedData is IRedLegacySingleChannelCurve curve && curve.ElementType.IsAssignableTo(item.GetType()))
            {
                curve.Add(0F, item);
            }
            else if (item is RedBaseClass rbc)
            {
                if (ResolvedData is IRedBufferPointer db)
                {
                    if (db.GetValue().Data is Package04 pkg)
                    {
                        if (index == -1 || index > pkg.Chunks.Count)
                        {
                            index = pkg.Chunks.Count;
                        }
                        pkg.Chunks.Insert(index, rbc);
                    }
                    else if (db.GetValue().Data is CR2WList list)
                    {
                        if (index == -1 || index > list.Files.Count)
                        {
                            index = list.Files.Count;
                        }
                        list.Files.Insert(index, new CR2WFile()
                        {
                            RootChunk = rbc
                        });
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            //Name = null;
            //PropertyCount = -1;
            //CalculateDescriptor();
            //PropertiesLoaded = false;
            //CalculateProperties();
            //Tab.File.SetIsDirty(true);

            Tab.File.SetIsDirty(true);
            RecalulateProperties(item);

            return true;
        }

        public void RecalulateProperties(IRedType selectChild = null)
        {
            PropertyCount = -1;
            // might not be needed
            CalculateDescriptor();
            PropertiesLoaded = false;
            CalculateProperties();

            this.RaisePropertyChanged("Data");

            IsExpanded = true;

            if (selectChild != null)
            {
                foreach (var prop in Properties)
                {
                    if (prop.Data.GetHashCode() == selectChild.GetHashCode())
                    {
                        prop.IsExpanded = true;
                        Tab.SelectedChunk = prop;
                        break;
                    }
                }
            }
        }

        public static bool IsControlBeingHeld => Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl);
    }
}
