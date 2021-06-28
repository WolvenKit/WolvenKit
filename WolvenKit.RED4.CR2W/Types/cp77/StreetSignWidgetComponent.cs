using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StreetSignWidgetComponent : IWorldWidgetComponent
	{
		private TweakDBID _streetSignTDBID;
		private CBool _isAStreetName;
		private TweakDBID _streetNameSignTDBID;
		private CHandle<inkTweakDBIDSelector> _signSelector;
		private CUInt32 _signVersion;

		[Ordinal(10)] 
		[RED("streetSignTDBID")] 
		public TweakDBID StreetSignTDBID
		{
			get => GetProperty(ref _streetSignTDBID);
			set => SetProperty(ref _streetSignTDBID, value);
		}

		[Ordinal(11)] 
		[RED("isAStreetName")] 
		public CBool IsAStreetName
		{
			get => GetProperty(ref _isAStreetName);
			set => SetProperty(ref _isAStreetName, value);
		}

		[Ordinal(12)] 
		[RED("streetNameSignTDBID")] 
		public TweakDBID StreetNameSignTDBID
		{
			get => GetProperty(ref _streetNameSignTDBID);
			set => SetProperty(ref _streetNameSignTDBID, value);
		}

		[Ordinal(13)] 
		[RED("signSelector")] 
		public CHandle<inkTweakDBIDSelector> SignSelector
		{
			get => GetProperty(ref _signSelector);
			set => SetProperty(ref _signSelector, value);
		}

		[Ordinal(14)] 
		[RED("signVersion")] 
		public CUInt32 SignVersion
		{
			get => GetProperty(ref _signVersion);
			set => SetProperty(ref _signVersion, value);
		}

		public StreetSignWidgetComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
