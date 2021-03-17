using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetAnimWrappersFromMountData : AIVehicleTaskAbstract
	{
		private CHandle<AIArgumentMapping> _mountData;

		[Ordinal(0)] 
		[RED("mountData")] 
		public CHandle<AIArgumentMapping> MountData
		{
			get => GetProperty(ref _mountData);
			set => SetProperty(ref _mountData, value);
		}

		public SetAnimWrappersFromMountData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
