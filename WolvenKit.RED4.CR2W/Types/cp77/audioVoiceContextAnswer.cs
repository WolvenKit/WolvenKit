using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceContextAnswer : CVariable
	{
		private CName _answerContext;
		private CFloat _radius;

		[Ordinal(0)] 
		[RED("answerContext")] 
		public CName AnswerContext
		{
			get
			{
				if (_answerContext == null)
				{
					_answerContext = (CName) CR2WTypeManager.Create("CName", "answerContext", cr2w, this);
				}
				return _answerContext;
			}
			set
			{
				if (_answerContext == value)
				{
					return;
				}
				_answerContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CFloat) CR2WTypeManager.Create("Float", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		public audioVoiceContextAnswer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
