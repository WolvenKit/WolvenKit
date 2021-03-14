using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForceVisionApperanceEvent : redEvent
	{
		private CHandle<FocusForcedHighlightData> _forcedHighlight;
		private CBool _apply;
		private CBool _forceCancel;
		private CBool _ignoreStackEvaluation;
		private CHandle<IScriptable> _responseData;

		[Ordinal(0)] 
		[RED("forcedHighlight")] 
		public CHandle<FocusForcedHighlightData> ForcedHighlight
		{
			get
			{
				if (_forcedHighlight == null)
				{
					_forcedHighlight = (CHandle<FocusForcedHighlightData>) CR2WTypeManager.Create("handle:FocusForcedHighlightData", "forcedHighlight", cr2w, this);
				}
				return _forcedHighlight;
			}
			set
			{
				if (_forcedHighlight == value)
				{
					return;
				}
				_forcedHighlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("apply")] 
		public CBool Apply
		{
			get
			{
				if (_apply == null)
				{
					_apply = (CBool) CR2WTypeManager.Create("Bool", "apply", cr2w, this);
				}
				return _apply;
			}
			set
			{
				if (_apply == value)
				{
					return;
				}
				_apply = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("forceCancel")] 
		public CBool ForceCancel
		{
			get
			{
				if (_forceCancel == null)
				{
					_forceCancel = (CBool) CR2WTypeManager.Create("Bool", "forceCancel", cr2w, this);
				}
				return _forceCancel;
			}
			set
			{
				if (_forceCancel == value)
				{
					return;
				}
				_forceCancel = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ignoreStackEvaluation")] 
		public CBool IgnoreStackEvaluation
		{
			get
			{
				if (_ignoreStackEvaluation == null)
				{
					_ignoreStackEvaluation = (CBool) CR2WTypeManager.Create("Bool", "ignoreStackEvaluation", cr2w, this);
				}
				return _ignoreStackEvaluation;
			}
			set
			{
				if (_ignoreStackEvaluation == value)
				{
					return;
				}
				_ignoreStackEvaluation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("responseData")] 
		public CHandle<IScriptable> ResponseData
		{
			get
			{
				if (_responseData == null)
				{
					_responseData = (CHandle<IScriptable>) CR2WTypeManager.Create("handle:IScriptable", "responseData", cr2w, this);
				}
				return _responseData;
			}
			set
			{
				if (_responseData == value)
				{
					return;
				}
				_responseData = value;
				PropertySet(this);
			}
		}

		public ForceVisionApperanceEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
