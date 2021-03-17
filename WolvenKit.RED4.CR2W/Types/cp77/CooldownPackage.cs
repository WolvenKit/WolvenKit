using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CooldownPackage : IScriptable
	{
		private TweakDBID _actionID;
		private CArray<PSOwnerData> _addressees;
		private CFloat _initialCooldown;
		private CooldownStorageID _label;
		private CEnum<PackageStatus> _packageStatus;

		[Ordinal(0)] 
		[RED("actionID")] 
		public TweakDBID ActionID
		{
			get => GetProperty(ref _actionID);
			set => SetProperty(ref _actionID, value);
		}

		[Ordinal(1)] 
		[RED("addressees")] 
		public CArray<PSOwnerData> Addressees
		{
			get => GetProperty(ref _addressees);
			set => SetProperty(ref _addressees, value);
		}

		[Ordinal(2)] 
		[RED("initialCooldown")] 
		public CFloat InitialCooldown
		{
			get => GetProperty(ref _initialCooldown);
			set => SetProperty(ref _initialCooldown, value);
		}

		[Ordinal(3)] 
		[RED("label")] 
		public CooldownStorageID Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(4)] 
		[RED("packageStatus")] 
		public CEnum<PackageStatus> PackageStatus
		{
			get => GetProperty(ref _packageStatus);
			set => SetProperty(ref _packageStatus, value);
		}

		public CooldownPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
