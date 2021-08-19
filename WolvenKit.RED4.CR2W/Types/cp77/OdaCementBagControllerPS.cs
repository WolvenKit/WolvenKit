using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OdaCementBagControllerPS : ScriptableDeviceComponentPS
	{
		private CFloat _cementEffectCooldown;

		[Ordinal(104)] 
		[RED("cementEffectCooldown")] 
		public CFloat CementEffectCooldown
		{
			get => GetProperty(ref _cementEffectCooldown);
			set => SetProperty(ref _cementEffectCooldown, value);
		}

		public OdaCementBagControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
