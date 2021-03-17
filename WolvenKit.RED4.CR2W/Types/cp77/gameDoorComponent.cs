using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDoorComponent : entIComponent
	{
		private CBool _interactible;
		private CBool _automatic;
		private CBool _physical;
		private CFloat _autoOpeningSpeed;

		[Ordinal(3)] 
		[RED("interactible")] 
		public CBool Interactible
		{
			get => GetProperty(ref _interactible);
			set => SetProperty(ref _interactible, value);
		}

		[Ordinal(4)] 
		[RED("automatic")] 
		public CBool Automatic
		{
			get => GetProperty(ref _automatic);
			set => SetProperty(ref _automatic, value);
		}

		[Ordinal(5)] 
		[RED("physical")] 
		public CBool Physical
		{
			get => GetProperty(ref _physical);
			set => SetProperty(ref _physical, value);
		}

		[Ordinal(6)] 
		[RED("autoOpeningSpeed")] 
		public CFloat AutoOpeningSpeed
		{
			get => GetProperty(ref _autoOpeningSpeed);
			set => SetProperty(ref _autoOpeningSpeed, value);
		}

		public gameDoorComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
