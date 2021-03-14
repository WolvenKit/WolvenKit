using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OxygenStatListener : gameCustomValueStatPoolsListener
	{
		private wCHandle<PlayerPuppet> _ownerPuppet;
		private CHandle<worldEffectBlackboard> _oxygenVfxBlackboard;

		[Ordinal(0)] 
		[RED("ownerPuppet")] 
		public wCHandle<PlayerPuppet> OwnerPuppet
		{
			get
			{
				if (_ownerPuppet == null)
				{
					_ownerPuppet = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "ownerPuppet", cr2w, this);
				}
				return _ownerPuppet;
			}
			set
			{
				if (_ownerPuppet == value)
				{
					return;
				}
				_ownerPuppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("oxygenVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> OxygenVfxBlackboard
		{
			get
			{
				if (_oxygenVfxBlackboard == null)
				{
					_oxygenVfxBlackboard = (CHandle<worldEffectBlackboard>) CR2WTypeManager.Create("handle:worldEffectBlackboard", "oxygenVfxBlackboard", cr2w, this);
				}
				return _oxygenVfxBlackboard;
			}
			set
			{
				if (_oxygenVfxBlackboard == value)
				{
					return;
				}
				_oxygenVfxBlackboard = value;
				PropertySet(this);
			}
		}

		public OxygenStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
