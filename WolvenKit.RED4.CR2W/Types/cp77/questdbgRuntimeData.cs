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
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		[Ordinal(1)] 
		[RED("questResourcePathHash")] 
		public CUInt64 QuestResourcePathHash
		{
			get => GetProperty(ref _questResourcePathHash);
			set => SetProperty(ref _questResourcePathHash, value);
		}

		[Ordinal(2)] 
		[RED("selectedBlockId")] 
		public CUInt64 SelectedBlockId
		{
			get => GetProperty(ref _selectedBlockId);
			set => SetProperty(ref _selectedBlockId, value);
		}

		[Ordinal(3)] 
		[RED("objects")] 
		public CArray<CHandle<ISerializable>> Objects
		{
			get => GetProperty(ref _objects);
			set => SetProperty(ref _objects, value);
		}

		public questdbgRuntimeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
