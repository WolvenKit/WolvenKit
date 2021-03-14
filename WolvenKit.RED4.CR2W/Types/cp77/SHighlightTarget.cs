using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SHighlightTarget : CVariable
	{
		private entEntityID _targetID;
		private CEnum<EFocusForcedHighlightType> _highlightType;

		[Ordinal(0)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get
			{
				if (_targetID == null)
				{
					_targetID = (entEntityID) CR2WTypeManager.Create("entEntityID", "targetID", cr2w, this);
				}
				return _targetID;
			}
			set
			{
				if (_targetID == value)
				{
					return;
				}
				_targetID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("highlightType")] 
		public CEnum<EFocusForcedHighlightType> HighlightType
		{
			get
			{
				if (_highlightType == null)
				{
					_highlightType = (CEnum<EFocusForcedHighlightType>) CR2WTypeManager.Create("EFocusForcedHighlightType", "highlightType", cr2w, this);
				}
				return _highlightType;
			}
			set
			{
				if (_highlightType == value)
				{
					return;
				}
				_highlightType = value;
				PropertySet(this);
			}
		}

		public SHighlightTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
