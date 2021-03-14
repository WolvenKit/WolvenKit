using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayContainerCreatedEvent : redEvent
	{
		private CInt32 _index;
		private CBool _isTrait;
		private wCHandle<PerkDisplayContainerController> _container;

		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get
			{
				if (_index == null)
				{
					_index = (CInt32) CR2WTypeManager.Create("Int32", "index", cr2w, this);
				}
				return _index;
			}
			set
			{
				if (_index == value)
				{
					return;
				}
				_index = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isTrait")] 
		public CBool IsTrait
		{
			get
			{
				if (_isTrait == null)
				{
					_isTrait = (CBool) CR2WTypeManager.Create("Bool", "isTrait", cr2w, this);
				}
				return _isTrait;
			}
			set
			{
				if (_isTrait == value)
				{
					return;
				}
				_isTrait = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("container")] 
		public wCHandle<PerkDisplayContainerController> Container
		{
			get
			{
				if (_container == null)
				{
					_container = (wCHandle<PerkDisplayContainerController>) CR2WTypeManager.Create("whandle:PerkDisplayContainerController", "container", cr2w, this);
				}
				return _container;
			}
			set
			{
				if (_container == value)
				{
					return;
				}
				_container = value;
				PropertySet(this);
			}
		}

		public PerkDisplayContainerCreatedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
