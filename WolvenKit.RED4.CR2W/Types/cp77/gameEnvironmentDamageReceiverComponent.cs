using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEnvironmentDamageReceiverComponent : entIPlacedComponent
	{
		private CFloat _cooldown;
		private CArray<CHandle<gameEnvironmentDamageReceiverShape>> _shapes;

		[Ordinal(5)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get
			{
				if (_cooldown == null)
				{
					_cooldown = (CFloat) CR2WTypeManager.Create("Float", "cooldown", cr2w, this);
				}
				return _cooldown;
			}
			set
			{
				if (_cooldown == value)
				{
					return;
				}
				_cooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("shapes")] 
		public CArray<CHandle<gameEnvironmentDamageReceiverShape>> Shapes
		{
			get
			{
				if (_shapes == null)
				{
					_shapes = (CArray<CHandle<gameEnvironmentDamageReceiverShape>>) CR2WTypeManager.Create("array:handle:gameEnvironmentDamageReceiverShape", "shapes", cr2w, this);
				}
				return _shapes;
			}
			set
			{
				if (_shapes == value)
				{
					return;
				}
				_shapes = value;
				PropertySet(this);
			}
		}

		public gameEnvironmentDamageReceiverComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
