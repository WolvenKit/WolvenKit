using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questdbgRuntimeData : CVariable
	{
		private CUInt64 _version;
		private CUInt64 _questResourcePathHash;
		private CUInt64 _selectedBlockId;
		private CArray<CHandle<ISerializable>> _objects;

		[Ordinal(0)] 
		[RED("version")] 
		public CUInt64 Version
		{
			get
			{
				if (_version == null)
				{
					_version = (CUInt64) CR2WTypeManager.Create("Uint64", "version", cr2w, this);
				}
				return _version;
			}
			set
			{
				if (_version == value)
				{
					return;
				}
				_version = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("questResourcePathHash")] 
		public CUInt64 QuestResourcePathHash
		{
			get
			{
				if (_questResourcePathHash == null)
				{
					_questResourcePathHash = (CUInt64) CR2WTypeManager.Create("Uint64", "questResourcePathHash", cr2w, this);
				}
				return _questResourcePathHash;
			}
			set
			{
				if (_questResourcePathHash == value)
				{
					return;
				}
				_questResourcePathHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("selectedBlockId")] 
		public CUInt64 SelectedBlockId
		{
			get
			{
				if (_selectedBlockId == null)
				{
					_selectedBlockId = (CUInt64) CR2WTypeManager.Create("Uint64", "selectedBlockId", cr2w, this);
				}
				return _selectedBlockId;
			}
			set
			{
				if (_selectedBlockId == value)
				{
					return;
				}
				_selectedBlockId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("objects")] 
		public CArray<CHandle<ISerializable>> Objects
		{
			get
			{
				if (_objects == null)
				{
					_objects = (CArray<CHandle<ISerializable>>) CR2WTypeManager.Create("array:handle:ISerializable", "objects", cr2w, this);
				}
				return _objects;
			}
			set
			{
				if (_objects == value)
				{
					return;
				}
				_objects = value;
				PropertySet(this);
			}
		}

		public questdbgRuntimeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
