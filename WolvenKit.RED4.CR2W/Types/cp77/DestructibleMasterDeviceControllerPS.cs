using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DestructibleMasterDeviceControllerPS : MasterControllerPS
	{
		private CBool _isDestroyed;

		[Ordinal(104)] 
		[RED("isDestroyed")] 
		public CBool IsDestroyed
		{
			get
			{
				if (_isDestroyed == null)
				{
					_isDestroyed = (CBool) CR2WTypeManager.Create("Bool", "isDestroyed", cr2w, this);
				}
				return _isDestroyed;
			}
			set
			{
				if (_isDestroyed == value)
				{
					return;
				}
				_isDestroyed = value;
				PropertySet(this);
			}
		}

		public DestructibleMasterDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
