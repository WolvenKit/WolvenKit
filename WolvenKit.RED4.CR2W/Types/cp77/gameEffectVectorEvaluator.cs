using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectVectorEvaluator : ISerializable
	{
		private CFloat _modifier;

		[Ordinal(0)] 
		[RED("modifier")] 
		public CFloat Modifier
		{
			get
			{
				if (_modifier == null)
				{
					_modifier = (CFloat) CR2WTypeManager.Create("Float", "modifier", cr2w, this);
				}
				return _modifier;
			}
			set
			{
				if (_modifier == value)
				{
					return;
				}
				_modifier = value;
				PropertySet(this);
			}
		}

		public gameEffectVectorEvaluator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
