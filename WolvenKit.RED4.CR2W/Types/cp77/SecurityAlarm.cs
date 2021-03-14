using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAlarm : InteractiveMasterDevice
	{
		private CHandle<entMeshComponent> _workingAlarm;
		private CHandle<entMeshComponent> _destroyedAlarm;
		private CBool _isGlitching;

		[Ordinal(93)] 
		[RED("workingAlarm")] 
		public CHandle<entMeshComponent> WorkingAlarm
		{
			get
			{
				if (_workingAlarm == null)
				{
					_workingAlarm = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "workingAlarm", cr2w, this);
				}
				return _workingAlarm;
			}
			set
			{
				if (_workingAlarm == value)
				{
					return;
				}
				_workingAlarm = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("destroyedAlarm")] 
		public CHandle<entMeshComponent> DestroyedAlarm
		{
			get
			{
				if (_destroyedAlarm == null)
				{
					_destroyedAlarm = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "destroyedAlarm", cr2w, this);
				}
				return _destroyedAlarm;
			}
			set
			{
				if (_destroyedAlarm == value)
				{
					return;
				}
				_destroyedAlarm = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("isGlitching")] 
		public CBool IsGlitching
		{
			get
			{
				if (_isGlitching == null)
				{
					_isGlitching = (CBool) CR2WTypeManager.Create("Bool", "isGlitching", cr2w, this);
				}
				return _isGlitching;
			}
			set
			{
				if (_isGlitching == value)
				{
					return;
				}
				_isGlitching = value;
				PropertySet(this);
			}
		}

		public SecurityAlarm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
