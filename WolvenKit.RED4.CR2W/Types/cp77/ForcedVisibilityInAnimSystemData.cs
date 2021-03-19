using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForcedVisibilityInAnimSystemData : IScriptable
	{
		private CName _sourceName;
		private gameDelayID _delayID;
		private CBool _forcedVisibleOnlyInFrustum;

		[Ordinal(0)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get => GetProperty(ref _sourceName);
			set => SetProperty(ref _sourceName, value);
		}

		[Ordinal(1)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get => GetProperty(ref _delayID);
			set => SetProperty(ref _delayID, value);
		}

		[Ordinal(2)] 
		[RED("forcedVisibleOnlyInFrustum")] 
		public CBool ForcedVisibleOnlyInFrustum
		{
			get => GetProperty(ref _forcedVisibleOnlyInFrustum);
			set => SetProperty(ref _forcedVisibleOnlyInFrustum, value);
		}

		public ForcedVisibilityInAnimSystemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
