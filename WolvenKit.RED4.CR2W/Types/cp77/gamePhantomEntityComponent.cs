using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePhantomEntityComponent : entIComponent
	{
		private gamePhantomEntityParameters _params;
		private CHandle<gameEffectComponentBinding> _effectBinding;

		[Ordinal(3)] 
		[RED("params")] 
		public gamePhantomEntityParameters Params
		{
			get
			{
				if (_params == null)
				{
					_params = (gamePhantomEntityParameters) CR2WTypeManager.Create("gamePhantomEntityParameters", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("effectBinding")] 
		public CHandle<gameEffectComponentBinding> EffectBinding
		{
			get
			{
				if (_effectBinding == null)
				{
					_effectBinding = (CHandle<gameEffectComponentBinding>) CR2WTypeManager.Create("handle:gameEffectComponentBinding", "effectBinding", cr2w, this);
				}
				return _effectBinding;
			}
			set
			{
				if (_effectBinding == value)
				{
					return;
				}
				_effectBinding = value;
				PropertySet(this);
			}
		}

		public gamePhantomEntityComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
