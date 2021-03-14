using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimMathExpressionFloatSocket : CVariable
	{
		private animFloatLink _link;
		private CUInt16 _expressionVarId;
		private animNamedTrackIndex _inputFloatTrack;

		[Ordinal(0)] 
		[RED("link")] 
		public animFloatLink Link
		{
			get
			{
				if (_link == null)
				{
					_link = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "link", cr2w, this);
				}
				return _link;
			}
			set
			{
				if (_link == value)
				{
					return;
				}
				_link = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("expressionVarId")] 
		public CUInt16 ExpressionVarId
		{
			get
			{
				if (_expressionVarId == null)
				{
					_expressionVarId = (CUInt16) CR2WTypeManager.Create("Uint16", "expressionVarId", cr2w, this);
				}
				return _expressionVarId;
			}
			set
			{
				if (_expressionVarId == value)
				{
					return;
				}
				_expressionVarId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("inputFloatTrack")] 
		public animNamedTrackIndex InputFloatTrack
		{
			get
			{
				if (_inputFloatTrack == null)
				{
					_inputFloatTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "inputFloatTrack", cr2w, this);
				}
				return _inputFloatTrack;
			}
			set
			{
				if (_inputFloatTrack == value)
				{
					return;
				}
				_inputFloatTrack = value;
				PropertySet(this);
			}
		}

		public animAnimMathExpressionFloatSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
