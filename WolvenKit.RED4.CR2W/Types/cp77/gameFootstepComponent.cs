using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameFootstepComponent : entIComponent
	{
		private TweakDBID _tweakDBID;
		private CName _leftFootSlot;
		private CName _rightFootSlot;

		[Ordinal(3)] 
		[RED("tweakDBID")] 
		public TweakDBID TweakDBID
		{
			get => GetProperty(ref _tweakDBID);
			set => SetProperty(ref _tweakDBID, value);
		}

		[Ordinal(4)] 
		[RED("leftFootSlot")] 
		public CName LeftFootSlot
		{
			get => GetProperty(ref _leftFootSlot);
			set => SetProperty(ref _leftFootSlot, value);
		}

		[Ordinal(5)] 
		[RED("rightFootSlot")] 
		public CName RightFootSlot
		{
			get => GetProperty(ref _rightFootSlot);
			set => SetProperty(ref _rightFootSlot, value);
		}

		public gameFootstepComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
