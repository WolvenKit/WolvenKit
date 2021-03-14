using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerColor : IParticleInitializer
	{
		private CHandle<IEvaluatorColor> _color;

		[Ordinal(4)] 
		[RED("color")] 
		public CHandle<IEvaluatorColor> Color
		{
			get
			{
				if (_color == null)
				{
					_color = (CHandle<IEvaluatorColor>) CR2WTypeManager.Create("handle:IEvaluatorColor", "color", cr2w, this);
				}
				return _color;
			}
			set
			{
				if (_color == value)
				{
					return;
				}
				_color = value;
				PropertySet(this);
			}
		}

		public CParticleInitializerColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
