public class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        next = null;
    }
}

public class LinkedList
{
    public static Node InsertAtHead(Node head, int data)
    {
        Node newNode = new Node(data);
        newNode.next = head;
        return newNode;
    }

    public static Node InsertAtTail(Node head, int data)
    {
        if (head == null)
        {
            return new Node(data);
        }

        Node current = head;
        while (current.next != null)
        {
            current = current.next;
        }

        current.next = new Node(data);
        return head;
    }

    public static Node InsertAtPosition(Node head, int data, int position)
    {
        if (position == 0)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            return newNode;
        }

        Node current = head;
        for (int i = 0; i < position - 1; i++)
        {
            current = current.next;
        }

        Node temp = current.next;
        current.next = new Node(data);
        current.next.next = temp;
        return head;
    }

    
}   