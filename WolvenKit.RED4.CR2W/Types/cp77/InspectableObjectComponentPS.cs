using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InspectableObjectComponentPS : gameComponentPS
	{
		private CBool _isStarted;
		private CBool _isFinished;
		private CArray<CHandle<questObjectInspectListener>> _listeners;

		[Ordinal(0)] 
		[RED("isStarted")] 
		public CBool IsStarted
		{
			get
			{
				if (_isStarted == null)
				{
					_isStarted = (CBool) CR2WTypeManager.Create("Bool", "isStarted", cr2w, this);
				}
				return _isStarted;
			}
			set
			{
				if (_isStarted == value)
				{
					return;
				}
				_isStarted = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isFinished")] 
		public CBool IsFinished
		{
			get
			{
				if (_isFinished == null)
				{
					_isFinished = (CBool) CR2WTypeManager.Create("Bool", "isFinished", cr2w, this);
				}
				return _isFinished;
			}
			set
			{
				if (_isFinished == value)
				{
					return;
				}
				_isFinished = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("listeners")] 
		public CArray<CHandle<questObjectInspectListener>> Listeners
		{
			get
			{
				if (_listeners == null)
				{
					_listeners = (CArray<CHandle<questObjectInspectListener>>) CR2WTypeManager.Create("array:handle:questObjectInspectListener", "listeners", cr2w, this);
				}
				return _listeners;
			}
			set
			{
				if (_listeners == value)
				{
					return;
				}
				_listeners = value;
				PropertySet(this);
			}
		}

		public InspectableObjectComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
