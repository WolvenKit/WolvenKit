using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisplayGlassControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _isTinted;
		private CBool _useAppearances;
		private CName _clearAppearance;
		private CName _tintedAppearance;

		[Ordinal(103)] 
		[RED("isTinted")] 
		public CBool IsTinted
		{
			get
			{
				if (_isTinted == null)
				{
					_isTinted = (CBool) CR2WTypeManager.Create("Bool", "isTinted", cr2w, this);
				}
				return _isTinted;
			}
			set
			{
				if (_isTinted == value)
				{
					return;
				}
				_isTinted = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("useAppearances")] 
		public CBool UseAppearances
		{
			get
			{
				if (_useAppearances == null)
				{
					_useAppearances = (CBool) CR2WTypeManager.Create("Bool", "useAppearances", cr2w, this);
				}
				return _useAppearances;
			}
			set
			{
				if (_useAppearances == value)
				{
					return;
				}
				_useAppearances = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("clearAppearance")] 
		public CName ClearAppearance
		{
			get
			{
				if (_clearAppearance == null)
				{
					_clearAppearance = (CName) CR2WTypeManager.Create("CName", "clearAppearance", cr2w, this);
				}
				return _clearAppearance;
			}
			set
			{
				if (_clearAppearance == value)
				{
					return;
				}
				_clearAppearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("tintedAppearance")] 
		public CName TintedAppearance
		{
			get
			{
				if (_tintedAppearance == null)
				{
					_tintedAppearance = (CName) CR2WTypeManager.Create("CName", "tintedAppearance", cr2w, this);
				}
				return _tintedAppearance;
			}
			set
			{
				if (_tintedAppearance == value)
				{
					return;
				}
				_tintedAppearance = value;
				PropertySet(this);
			}
		}

		public DisplayGlassControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
