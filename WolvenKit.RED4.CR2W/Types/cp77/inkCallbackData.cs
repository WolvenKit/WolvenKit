using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCallbackData : IScriptable
	{
		private CEnum<inkIconResult> _loadResult;
		private CHandle<inkImageWidget> _targetWidget;
		private CString _errorMsg;
		private TweakDBID _iconSrc;

		[Ordinal(0)] 
		[RED("loadResult")] 
		public CEnum<inkIconResult> LoadResult
		{
			get
			{
				if (_loadResult == null)
				{
					_loadResult = (CEnum<inkIconResult>) CR2WTypeManager.Create("inkIconResult", "loadResult", cr2w, this);
				}
				return _loadResult;
			}
			set
			{
				if (_loadResult == value)
				{
					return;
				}
				_loadResult = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetWidget")] 
		public CHandle<inkImageWidget> TargetWidget
		{
			get
			{
				if (_targetWidget == null)
				{
					_targetWidget = (CHandle<inkImageWidget>) CR2WTypeManager.Create("handle:inkImageWidget", "targetWidget", cr2w, this);
				}
				return _targetWidget;
			}
			set
			{
				if (_targetWidget == value)
				{
					return;
				}
				_targetWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("errorMsg")] 
		public CString ErrorMsg
		{
			get
			{
				if (_errorMsg == null)
				{
					_errorMsg = (CString) CR2WTypeManager.Create("String", "errorMsg", cr2w, this);
				}
				return _errorMsg;
			}
			set
			{
				if (_errorMsg == value)
				{
					return;
				}
				_errorMsg = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("iconSrc")] 
		public TweakDBID IconSrc
		{
			get
			{
				if (_iconSrc == null)
				{
					_iconSrc = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "iconSrc", cr2w, this);
				}
				return _iconSrc;
			}
			set
			{
				if (_iconSrc == value)
				{
					return;
				}
				_iconSrc = value;
				PropertySet(this);
			}
		}

		public inkCallbackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
