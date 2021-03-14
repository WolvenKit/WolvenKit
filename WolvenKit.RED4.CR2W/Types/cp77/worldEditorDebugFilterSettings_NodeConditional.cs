using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldEditorDebugFilterSettings_NodeConditional : worldEditorDebugFilterSettings
	{
		private CBool _isDiscarded;
		private CBool _isProxyDependencyModeAutoSet;
		private CBool _isProxyDependencyModeDiscardedSet;

		[Ordinal(0)] 
		[RED("isDiscarded")] 
		public CBool IsDiscarded
		{
			get
			{
				if (_isDiscarded == null)
				{
					_isDiscarded = (CBool) CR2WTypeManager.Create("Bool", "isDiscarded", cr2w, this);
				}
				return _isDiscarded;
			}
			set
			{
				if (_isDiscarded == value)
				{
					return;
				}
				_isDiscarded = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isProxyDependencyModeAutoSet")] 
		public CBool IsProxyDependencyModeAutoSet
		{
			get
			{
				if (_isProxyDependencyModeAutoSet == null)
				{
					_isProxyDependencyModeAutoSet = (CBool) CR2WTypeManager.Create("Bool", "isProxyDependencyModeAutoSet", cr2w, this);
				}
				return _isProxyDependencyModeAutoSet;
			}
			set
			{
				if (_isProxyDependencyModeAutoSet == value)
				{
					return;
				}
				_isProxyDependencyModeAutoSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isProxyDependencyModeDiscardedSet")] 
		public CBool IsProxyDependencyModeDiscardedSet
		{
			get
			{
				if (_isProxyDependencyModeDiscardedSet == null)
				{
					_isProxyDependencyModeDiscardedSet = (CBool) CR2WTypeManager.Create("Bool", "isProxyDependencyModeDiscardedSet", cr2w, this);
				}
				return _isProxyDependencyModeDiscardedSet;
			}
			set
			{
				if (_isProxyDependencyModeDiscardedSet == value)
				{
					return;
				}
				_isProxyDependencyModeDiscardedSet = value;
				PropertySet(this);
			}
		}

		public worldEditorDebugFilterSettings_NodeConditional(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
