using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimInputSetterAnimFeature : entAnimInputSetter
	{
		private CHandle<animAnimFeature> _value;
		private CFloat _delay;

		[Ordinal(1)] 
		[RED("value")] 
		public CHandle<animAnimFeature> Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CHandle<animAnimFeature>) CR2WTypeManager.Create("handle:animAnimFeature", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get
			{
				if (_delay == null)
				{
					_delay = (CFloat) CR2WTypeManager.Create("Float", "delay", cr2w, this);
				}
				return _delay;
			}
			set
			{
				if (_delay == value)
				{
					return;
				}
				_delay = value;
				PropertySet(this);
			}
		}

		public entAnimInputSetterAnimFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
