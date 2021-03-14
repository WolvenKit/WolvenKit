using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VentilationAreaControllerPS : MasterControllerPS
	{
		private VentilationAreaSetup _ventilationAreaSetup;
		private CBool _isActive;

		[Ordinal(104)] 
		[RED("ventilationAreaSetup")] 
		public VentilationAreaSetup VentilationAreaSetup
		{
			get
			{
				if (_ventilationAreaSetup == null)
				{
					_ventilationAreaSetup = (VentilationAreaSetup) CR2WTypeManager.Create("VentilationAreaSetup", "ventilationAreaSetup", cr2w, this);
				}
				return _ventilationAreaSetup;
			}
			set
			{
				if (_ventilationAreaSetup == value)
				{
					return;
				}
				_ventilationAreaSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		public VentilationAreaControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
