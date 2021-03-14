using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IParticleModule : ISerializable
	{
		private CString _editorName;
		private CString _editorGroup;
		private CBool _isEnabled;

		[Ordinal(0)] 
		[RED("editorName")] 
		public CString EditorName
		{
			get
			{
				if (_editorName == null)
				{
					_editorName = (CString) CR2WTypeManager.Create("String", "editorName", cr2w, this);
				}
				return _editorName;
			}
			set
			{
				if (_editorName == value)
				{
					return;
				}
				_editorName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("editorGroup")] 
		public CString EditorGroup
		{
			get
			{
				if (_editorGroup == null)
				{
					_editorGroup = (CString) CR2WTypeManager.Create("String", "editorGroup", cr2w, this);
				}
				return _editorGroup;
			}
			set
			{
				if (_editorGroup == value)
				{
					return;
				}
				_editorGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public IParticleModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
