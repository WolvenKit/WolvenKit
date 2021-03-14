using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AOEEffectorControllerPS : ActivatedDeviceControllerPS
	{
		private CArray<CName> _effectsToPlay;

		[Ordinal(107)] 
		[RED("effectsToPlay")] 
		public CArray<CName> EffectsToPlay
		{
			get
			{
				if (_effectsToPlay == null)
				{
					_effectsToPlay = (CArray<CName>) CR2WTypeManager.Create("array:CName", "effectsToPlay", cr2w, this);
				}
				return _effectsToPlay;
			}
			set
			{
				if (_effectsToPlay == value)
				{
					return;
				}
				_effectsToPlay = value;
				PropertySet(this);
			}
		}

		public AOEEffectorControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
