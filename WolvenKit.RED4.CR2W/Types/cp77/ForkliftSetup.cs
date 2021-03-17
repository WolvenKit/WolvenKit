using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForkliftSetup : CVariable
	{
		private CName _actionActivateName;
		private CFloat _liftingAnimationTime;
		private CBool _hasDistractionQuickhack;

		[Ordinal(0)] 
		[RED("actionActivateName")] 
		public CName ActionActivateName
		{
			get => GetProperty(ref _actionActivateName);
			set => SetProperty(ref _actionActivateName, value);
		}

		[Ordinal(1)] 
		[RED("liftingAnimationTime")] 
		public CFloat LiftingAnimationTime
		{
			get => GetProperty(ref _liftingAnimationTime);
			set => SetProperty(ref _liftingAnimationTime, value);
		}

		[Ordinal(2)] 
		[RED("hasDistractionQuickhack")] 
		public CBool HasDistractionQuickhack
		{
			get => GetProperty(ref _hasDistractionQuickhack);
			set => SetProperty(ref _hasDistractionQuickhack, value);
		}

		public ForkliftSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
