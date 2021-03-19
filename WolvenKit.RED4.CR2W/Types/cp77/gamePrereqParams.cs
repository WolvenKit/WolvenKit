using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePrereqParams : CVariable
	{
		private gameStatsObjectID _objectID;
		private gameStatsObjectID _otherObjectID;
		private CVariant _otherData;

		[Ordinal(0)] 
		[RED("objectID")] 
		public gameStatsObjectID ObjectID
		{
			get => GetProperty(ref _objectID);
			set => SetProperty(ref _objectID, value);
		}

		[Ordinal(1)] 
		[RED("otherObjectID")] 
		public gameStatsObjectID OtherObjectID
		{
			get => GetProperty(ref _otherObjectID);
			set => SetProperty(ref _otherObjectID, value);
		}

		[Ordinal(2)] 
		[RED("otherData")] 
		public CVariant OtherData
		{
			get => GetProperty(ref _otherData);
			set => SetProperty(ref _otherData, value);
		}

		public gamePrereqParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
