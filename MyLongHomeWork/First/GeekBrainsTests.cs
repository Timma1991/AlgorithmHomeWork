using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsTests
{
    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
    }
    //��������� � �������� ���� ����� ������� � ����� ���������� ����������
    public interface ILinkedList
    {
        int GetCount(); // ���������� ���������� ��������� � ������
        void AddNode(int value); // ��������� ����� ������� ������
        void AddNodeAfter(Node node, int value); // ��������� ����� �������
                                                 //������ ����� ������������ ��������
        void RemoveNode(int index); // ������� ������� �� ����������� ������
        void RemoveNode(Node node); // ������� ��������� �������
        Node FindNode(int searchValue); // ���� ������� �� ��� ��������
    }
}