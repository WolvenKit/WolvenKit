using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_EditorOnlyPredictiveLookAt : animAnimFeature
	{
		private CBool _isEnabled;
		private Vector4 _target;
		private CFloat _suppress;
		private CInt32 _mode;

		[Ordinal(0)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("target")] 
		public Vector4 Target
		{
			get
			{
				if (_target == null)
				{
					_target = (Vector4) CR2WTypeManager.Create("Vector4", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("suppress")] 
		public CFloat Suppress
		{
			get
			{
				if (_suppress == null)
				{
					_suppress = (CFloat) CR2WTypeManager.Create("Float", "suppress", cr2w, this);
				}
				return _suppress;
			}
			set
			{
				if (_suppress == value)
				{
					return;
				}
				_suppress = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("mode")] 
		public CInt32 Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CInt32) CR2WTypeManager.Create("Int32", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_EditorOnlyPredictiveLookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
