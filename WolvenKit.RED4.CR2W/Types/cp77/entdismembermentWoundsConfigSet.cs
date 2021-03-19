using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentWoundsConfigSet : CVariable
	{
		private CArray<CHandle<entdismembermentWoundConfigContainer>> _configs;

		[Ordinal(0)] 
		[RED("Configs")] 
		public CArray<CHandle<entdismembermentWoundConfigContainer>> Configs
		{
			get => GetProperty(ref _configs);
			set => SetProperty(ref _configs, value);
		}

		public entdismembermentWoundsConfigSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
