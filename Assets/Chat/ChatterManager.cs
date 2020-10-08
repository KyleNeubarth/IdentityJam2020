using System;
using System.Security.Cryptography;
using BeardedManStudios.Forge.Networking;
using BeardedManStudios.Forge.Networking.Frame;
using BeardedManStudios.Forge.Networking.Generated;
using UnityEngine;
using UnityEngine.UI;

public class ChatterManager : ChatterManagerBehavior
{
    public Transform chatContent;
    public GameObject chatMessage;

    private string username;

    protected override void NetworkStart()
    {
        base.NetworkStart();

        if (networkObject.IsServer)
        {
            username = "Server";
        }
        else
        {
            username = "Client";
        }
    }
    public void WriteMessage(InputField sender)
    {
        if (!string.IsNullOrEmpty(sender.text) && sender.text.Trim().Length > 0)
        {
            //trim and sanitize the string message
            sender.text = sender.text.Replace("\r", string.Empty).Replace("\n", string.Empty);
            networkObject.SendRpc(RPC_TRANSMIT_MESSAGE, Receivers.All, username, sender.text.Trim());
            sender.text = string.Empty;

            sender.ActivateInputField();
        }
    }

    public override void TransmitMessage(RpcArgs args)
    {
        string username = args.GetNext<string>();
        string message = args.GetNext<string>();

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(message))
        {
            // The message or username was empty, so do not display this message to anyone
            return;
        }

        GameObject newMessage = Instantiate(chatMessage, chatContent);
        UnityEngine.UI.Text content = newMessage.GetComponent<UnityEngine.UI.Text>();

        content.text = string.Format(content.text, username, message);
    }
}
