using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectParameter_IntEvaluator_Value : gameIEffectParameter_IntEvaluator
	{
		private CUInt32 _value;

		[Ordinal(0)] 
		[RED("value")] 
		public CUInt32 Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CUInt32) CR2WTypeManager.Create("Uint32", "value", cr2w, this);
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

		public gameEffectParameter_IntEvaluator_Value(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
