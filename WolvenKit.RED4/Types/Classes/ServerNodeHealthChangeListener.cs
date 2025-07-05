using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ServerNodeHealthChangeListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("serverNode")] 
		public CWeakHandle<ServerNode> ServerNode
		{
			get => GetPropertyValue<CWeakHandle<ServerNode>>();
			set => SetPropertyValue<CWeakHandle<ServerNode>>(value);
		}

		public ServerNodeHealthChangeListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
