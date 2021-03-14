using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameItemDropObject : gameLootObject
	{
		private CBool _wasItemInitialized;

		[Ordinal(43)] 
		[RED("wasItemInitialized")] 
		public CBool WasItemInitialized
		{
			get
			{
				if (_wasItemInitialized == null)
				{
					_wasItemInitialized = (CBool) CR2WTypeManager.Create("Bool", "wasItemInitialized", cr2w, this);
				}
				return _wasItemInitialized;
			}
			set
			{
				if (_wasItemInitialized == value)
				{
					return;
				}
				_wasItemInitialized = value;
				PropertySet(this);
			}
		}

		public gameItemDropObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
