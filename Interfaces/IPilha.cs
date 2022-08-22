﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaPilha.Interfaces
{
    public interface IPilha<T>
    {
        public void Empilha(T obj);
        public T Desempilha();
        public T Topo();

        public int Tamanho();

        public IEnumerable<T> RetornaTodosElementos();

        public bool EstaVazia();

        public IEnumerable<T> Esvaziar();

        public void EmpilhaValorUnico(T k);
    }
}
