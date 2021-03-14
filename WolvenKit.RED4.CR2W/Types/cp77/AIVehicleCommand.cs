using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIVehicleCommand : AICommand
	{
		private CBool _useKinematic;
		private CBool _needDriver;

		[Ordinal(4)] 
		[RED("useKinematic")] 
		public CBool UseKinematic
		{
			get
			{
				if (_useKinematic == null)
				{
					_useKinematic = (CBool) CR2WTypeManager.Create("Bool", "useKinematic", cr2w, this);
				}
				return _useKinematic;
			}
			set
			{
				if (_useKinematic == value)
				{
					return;
				}
				_useKinematic = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("needDriver")] 
		public CBool NeedDriver
		{
			get
			{
				if (_needDriver == null)
				{
					_needDriver = (CBool) CR2WTypeManager.Create("Bool", "needDriver", cr2w, this);
				}
				return _needDriver;
			}
			set
			{
				if (_needDriver == value)
				{
					return;
				}
				_needDriver = value;
				PropertySet(this);
			}
		}

		public AIVehicleCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
