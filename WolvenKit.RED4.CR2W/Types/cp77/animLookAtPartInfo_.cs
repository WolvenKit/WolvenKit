using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtPartInfo_ : CVariable
	{
		private CName _partName;
		private CName _defaultPositionBoneName;

		[Ordinal(0)] 
		[RED("partName")] 
		public CName PartName
		{
			get => GetProperty(ref _partName);
			set => SetProperty(ref _partName, value);
		}

		[Ordinal(1)] 
		[RED("defaultPositionBoneName")] 
		public CName DefaultPositionBoneName
		{
			get => GetProperty(ref _defaultPositionBoneName);
			set => SetProperty(ref _defaultPositionBoneName, value);
		}

		public animLookAtPartInfo_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
